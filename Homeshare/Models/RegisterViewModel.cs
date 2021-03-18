using Homeshare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Homeshare.Models
{
    public class RegisterViewModel
    {
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        private List<PaysListModel> _paysListModel;
        private RegisterModel _registerModel;

        public RegisterViewModel()
        {
            PaysListModel = ctx.SelectPays();
        }
        public RegisterModel RegisterModel
        {
            get
            {
                return _registerModel;
            }

            set
            {
                _registerModel = value;
            }
        }
        public List<PaysListModel> PaysListModel
        {
            get
            {
                return _paysListModel;
            }

            set
            {
                _paysListModel = value;
            }
        }
    }
}