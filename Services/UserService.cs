using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using taskTrackerBackend.Models;
using taskTrackerBackend.Models.DTO;
using taskTrackerBackend.Services.Context;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;

namespace taskTrackerBackend.Services
{
    public class UserService : ControllerBase
    {
        private readonly DataContext _context;

        public UserService(DataContext context)
        {
            _context = context;
        }

        // public bool DoesUserExist(string? Username)
        // {
        //     return _context.userInfo.SingleOrDefault(user => user.Username == Username) != null;
        // }
        // public bool AddUSer(CreateAccountDTO UserToAdd)
        // {
        //     bool result = false;

        //     if (!DoesUserExist(UserToAdd.Username))
        //     {
        //         UserModel newUser = new UserModel();

        //         var hashPassword = HashPassword(UserToAdd.Password);
        //         newUser.Id = UserToAdd.Id;
        //         newUser.Username = UserToAdd.Username;
        //         newUser.Salt = hashPassword.Salt;
        //         newUser.Hash = hashPassword.Hash;

        //         _context.Add(newUser);

        //         result = _context.SaveChanges() != 0;
        //     }
        //     return result;
        // }

        public PasswordDTO HashPassword(string password)
        {
            PasswordDTO newHashedPassword = new PasswordDTO();
            byte[] SaltByte = new byte[64];
            var provider = new RNGCryptoServiceProvider();
            provider.GetNonZeroBytes(SaltByte);

            var Salt = Convert.ToBase64String(SaltByte);

            Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, SaltByte, 10000);

            var Hash = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

            newHashedPassword.Salt = Salt;
            newHashedPassword.Hash = Hash;

            return newHashedPassword;


        }

        //  public bool UpdateUser(UserModel userToUpdate)
        // {
        //     // This one is sending over the whole object to be updated
        //     _context.Update<UserModel>(userToUpdate);
        //     return _context.SaveChanges() != 0;
        // }

        public bool VerifyUserPassword(string? Password, string? storedHash, string? storedSalt)
        {
            // get our existing Sal and change it to base 64 string
            var SaltBytes = Convert.FromBase64String(storedSalt);

            // Making a password that the user input and using the stored salt
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(Password, SaltBytes, 10000);
            // created the new hash
            var newHash = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

            return newHash == storedHash;
        }
    }
}