using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeshare.Entities
{
    public class MessageEntity
    {
        private int _idMessage;
        private string _nom, _email, _prenom, _message;

        public int IdMessage
        {
            get
            {
                return _idMessage;
            }

            set
            {
                _idMessage = value;
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

        public string Message
        {
            get
            {
                return _message;
            }

            set
            {
                _message = value;
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

    }
}
