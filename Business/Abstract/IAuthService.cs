
using Business.Dtos.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Request.User;
using Core.Entities;
using Core.Utilities.Security.JWT;

namespace Business.Abstract
{
    public interface IAuthService
    {
        void Register(RegisterRequest request, string password);
        AccessToken Login(LoginRequest request);
        void UserExists(string email);
        AccessToken CreateAccessToken(User user);
    }
}
