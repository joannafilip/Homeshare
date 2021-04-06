using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeshare.Models
{
   public class BienEchangeModel
    {
        private string _titre, _descCourte, _descLong, _ville, _rue, _numero, _codePostal, _photo, _latitude, _longitude, _pays;
        private int _idBien, _nombrePerson, _idPays, _idMembre, _note;
        private bool _assuranceObligatoire, _isEnabled;
        private DateTime _disabledDate, _dateCreation;
        private List<PaysListModel> _paysListModel;


        [Required]
        public string Titre
        {
            get
            {
                return _titre;
            }

            set
            {
                _titre = value;
            }
        }
        public string Pays
        {
            get
            {
                return _pays;
            }

            set
            {
                _pays = value;
            }
        }
        [Required]
        public string DescCourte
        {
            get
            {
                return _descCourte;
            }

            set
            {
                _descCourte = value;
            }
        }
        [Required]
        public string DescLong
        {
            get
            {
                return _descLong;
            }

            set
            {
                _descLong = value;
            }
        }
        [Required]
        public string Ville
        {
            get
            {
                return _ville;
            }

            set
            {
                _ville = value;
            }
        }
        [Required]
        public string Rue
        {
            get
            {
                return _rue;
            }

            set
            {
                _rue = value;
            }
        }
        [Required]
        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }
        [Required]
        public string CodePostale
        {
            get
            {
                return _codePostal;
            }

            set
            {
                _codePostal = value;
            }
        }
        [Required]
        public string Photo
        {
            get
            {
                return _photo;
            }

            set
            {
                _photo = value;
            }
        }
        public int Note
        {
            get
            {
                return _note;
            }

            set
            {
                _note = value;
            }
        }
        [Required]
        public int IdMembre
        {
            get
            {
                return _idMembre;
            }

            set
            {
                _idMembre = value;
            }
        }
        public int IdBien
        {
            get
            {
                return _idBien;
            }

            set
            {
                _idBien = value;
            }
        }
        [Required]
        public int IdPays
        {
            get
            {
                return _idPays;
            }

            set
            {
                _idPays = value;
            }
        }
        [Required]
        public int NombrePerson
        {
            get
            {
                return _nombrePerson;
            }

            set
            {
                _nombrePerson = value;
            }
        }
        [Required]
        public string Latitude
        {
            get
            {
                return _latitude;
            }

            set
            {
                _latitude = value;
            }
        }
        [Required]
        public string Longitude
        {
            get
            {
                return _longitude;
            }

            set
            {
                _longitude = value;
            }
        }
        [Required]
        public bool AssuranceObligatoire
        {
            get
            {
                return _assuranceObligatoire;
            }

            set
            {
                _assuranceObligatoire = value;
            }
        }
        [Required]
        public bool IsEnabled
        {
            get
            {
                return _isEnabled;
            }

            set
            {
                _isEnabled = value;
            }
        }
        [Required]
        public DateTime DisabledDate
        {
            get
            {
                return _disabledDate;
            }

            set
            {
                _disabledDate = value;
            }
        }
        [Required]
        public DateTime DateCreation
        {
            get
            {
                return _dateCreation;
            }

            set
            {
                _dateCreation = value;
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
