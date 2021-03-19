using Homeshare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Homeshare.Models
{
    public class AreaViewModel
    {
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        private List<PaysListModel> _paysListModel;
        private List<BienEchangeModel> _bienEchangeModel;

        public AreaViewModel()
        {

            PaysListModel = ctx.SelectPays();
        }
        public List<BienEchangeModel> RegisterModel
        {
            get
            {
                return _bienEchangeModel;
            }

            set
            {
                _bienEchangeModel = value;
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