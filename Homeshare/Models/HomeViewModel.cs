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
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        private LoginModel _loginModel;
        private List <BienEchangeModel> _topBienEchangeModel;
        private List<BienEchangeModel> _meilleursAvis;

        public HomeViewModel()
        {
            TopBienEchangeModel = ctx.GetCinqDernierBiens();
            MeilleursAvis = ctx.GetMeilleursAvis();
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
        public List<BienEchangeModel> TopBienEchangeModel
        {
            get
            {
                return _topBienEchangeModel;
            }

            set
            {
                _topBienEchangeModel = value;
            }
        }
        public List<BienEchangeModel> MeilleursAvis
        {
            get
            {
                return _meilleursAvis;
            }

            set
            {
                _meilleursAvis = value;
            }
        }
    }
}