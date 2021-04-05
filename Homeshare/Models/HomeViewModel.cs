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
        private List<BienEchangeModel> _topBienEchangeModel;
        private List<BienEchangeModel> _meilleursAvis;
        private List<BienEchangeModel> _allProperties;
        private List<BienEchangeModel> _hotProperties;
        private List<BienEchangeModel> _properties;
        private BienEchangeModel _targetBien;
        private int _maxProperty, _maxPage;

        public HomeViewModel()
        {
            MaxProperty = ctx.CountProperties();
            if ((MaxProperty % 3) == 0)
            {
                MaxPage = MaxProperty / 3;
            }
            else
            {
                double nbPage = MaxProperty / 3;
                MaxPage = (int)Math.Floor(nbPage) + 1;
            }
            TopBienEchangeModel = ctx.Get12DernierBiens();
            MeilleursAvis = ctx.GetMeilleursAvis();
            AllProperties = ctx.GetAllProperties();
            HotProperties = ctx.GetHotProperties();

        

        }
        public void PaginateProperty(int page = 1, string searchString = null)
        {
            Properties = ctx.GetPropertyByPage(page, searchString);
            if (searchString != null)
            {
                MaxProperty = ctx.CountPropertiesAllPage(page, searchString);
                if ((MaxProperty % 3) == 0)
                {
                    MaxPage = MaxProperty / 3;
                }
                else
                {
                    double nbPage = MaxProperty / 3;
                    MaxPage = (int)Math.Floor(nbPage) + 1;
                }
            }
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
        public List<BienEchangeModel> Properties
        {
            get
            {
                return _properties;
            }

            set
            {
                _properties = value;
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
        public int MaxProperty
        {
            get
            {
                return _maxProperty;
            }

            set
            {
                _maxProperty = value;
            }
        }
        public int MaxPage
        {
            get
            {
                return _maxPage;
            }

            set
            {
                _maxPage = value;
            }
        }
    }
}