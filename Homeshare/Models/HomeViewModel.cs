using Homeshare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Homeshare.Models
{
    public class HomeViewModel
    {
        private LoginModel _loginModel;

        public HomeViewModel()
        {

        }
        public LoginModel LoginModel
        {
            get
            {
                return _loginModel;
            }

            set
            {
                _loginModel = value;
            }
        }
    }
}