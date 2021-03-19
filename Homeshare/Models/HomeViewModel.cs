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

        public HomeViewModel()
        {
            TopBienEchangeModel = ctx.GetCinqDernierBiens();
            //TopBienEchangeModel = new List<BienEchangeModel>();
            //TopBienEchangeModel.Add(new BienEchangeModel() { Photo = "1.jpg", Titre = "Beautiful buildings you need to before dying", Ville = "Madryt", DateCreation = new DateTime(2020, 1, 3), Latitude = "45", Longitude = "45", DescCourte = "hhkhk", DescLong = "blabla", IsEnabled = true, NombrePerson = 2});

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
    }
}