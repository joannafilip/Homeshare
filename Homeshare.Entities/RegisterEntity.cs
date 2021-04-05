using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeshare.Entities
{
    public class RegisterEntity
    {
        private string _nom, _prenom, _email, _login, _password, _telephone, _libelle, _photo;
        private int _idPays, _idMembre;


        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }
        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string Login
        {
            get
            {
                return _login;
            }

            set
            {
                _login = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }
        public string Telephone
        {
            get
            {
                return _telephone;
            }

            set
            {
                _telephone = value;
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
        public string Libelle
        {
            get
            {
                return _libelle;
            }

            set
            {
                _libelle = value;
            }
        }

    }
}

