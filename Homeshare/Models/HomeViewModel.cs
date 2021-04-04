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
        private List<BienEchangeModel> _allProperties;
        private List<BienEchangeModel> _hotProperties;
        private BienEchangeModel _targetBien;


        public HomeViewModel()
        {
            TopBienEchangeModel = ctx.Get12DernierBiens();
            MeilleursAvis = ctx.GetMeilleursAvis();
            AllProperties = ctx.GetAllProperties();
            HotProperties = ctx.GetHotProperties();

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
        public List<BienEchangeModel> AllProperties
        {
            get
            {
                return _allProperties;
            }

            set
            {
                _allProperties = value;
            }
        }
        public List<BienEchangeModel> HotProperties
        {
            get
            {
                return _hotProperties;
            }

            set
            {
                _hotProperties = value;
            }
        }
        public BienEchangeModel TargetBien
        {
            get
            {
                return _targetBien;
            }

            set
            {
                _targetBien = value;
            }
        }
    }
}