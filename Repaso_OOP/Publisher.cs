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
        private HashSet<string> _games;
        private HashSet<string> _authors;

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

        public HashSet<string> Games
        {
            get { return _games; }
            set 
            {
                if (_games.Count > 0)
                {
                    _games = value;
                }
                else
                {
                    _games = new HashSet<string>();
                }
            }
        }

        public HashSet<string> Authors
        {
            get { return _authors; }
            set
            {
                if (_authors.Count > 0)
                {
                    _authors = value;
                }
                else
                {
                    _authors = new HashSet<string>();
                }
            }
        }

        public Publisher(string _name, string _country, HashSet<string> _games, HashSet<string> _authors)
        {
            this._name = _name;
            this._country = _country;
            this._games = _games;
            this._authors = _authors;
        }
    }
}
