﻿namespace ShopStar.Basket.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public LoginService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public string GetUserId => _contextAccessor.HttpContext.User.FindFirst("sub").Value;
        //sub icinde id var
        //sub tokendan gelecek
    }
}
