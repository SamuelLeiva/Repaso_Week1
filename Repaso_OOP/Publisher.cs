using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_OOP
{
    internal class Publisher
    {
        private string _name;
        private string _country;
        private string[] _games;
        private string[] _authors;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string[] Games
        {
            get { return _games; }
            set { _games = value; }
        }

        public string[] Authors
        {
            get { return _authors; }
            set { _authors = value; }
        }

        public Publisher(string _name, string _country, string[] _games, string[] _authors)
        {
            this._name = _name;
            this._country = _country;
            this._games = _games;
            this._authors = _authors;
        }
    }
}
