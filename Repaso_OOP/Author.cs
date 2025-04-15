using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_OOP
{
    internal class Author
    {
        private string _name;
        private string _lastname;
        private int _age;
        private HashSet<string> _games;

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public HashSet<string> Games
        {
            get { return _games; }
            set 
            { 
                if(_games.Count > 0)
                {
                    _games = value;
                } else
                {
                    _games = new HashSet<string>();
                }
                
            }
        }

        public Author(string _name, string _lastname,  int _age, HashSet<string> _games)
        {
            this._name = _name;
            this._lastname = _lastname;
            this._age = _age;
            this._games = _games;
        }
    }
}
