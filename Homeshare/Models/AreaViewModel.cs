using Homeshare.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Homeshare.Infra;

namespace Homeshare.Models
{
    public class AreaViewModel
    {
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);
        private List<PaysListModel> _paysListModel;
        private BienEchangeModel _bienEchangeModel;

        public AreaViewModel()
        {
            PaysListModel = ctx.SelectPays();
            
        }
        public AreaViewModel(BienEchangeModel bm)
        {
            
                ctx.InsertBien(bm);
        }


        public BienEchangeModel BienEchangeModel
        {
            get
            {
                return _bienEchangeModel;
            }

            set
            {
                _bienEchangeModel= value;
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