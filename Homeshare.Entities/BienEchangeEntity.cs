using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeshare.Entities
{
    public class BienEchangeEntity
    {
        private string _titre, _descCourte, _descLong, _ville, _rue, _numero, _codePostal, _photo, _latitude, _longitude;
        private int _idBien, _nombrePerson, _pays, _idMembre;
        private bool _assuranceObligatoire, _isEnabled;
        private DateTime _disabledDate, _dateCreation;

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
        public int Pays
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

    }
}
