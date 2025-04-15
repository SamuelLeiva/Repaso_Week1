using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_OOP
{
    internal class Boardgame
    {
        private string _title;
        private string _author;
        private double _grade;
        private int _minDuration;
        private double _weight;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public double Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public int MinDuration
        {
            get { return _minDuration; }
            set { _minDuration = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Boardgame(string _title, string _author, double _grade, int _minDuration, double _weight)
        {
            this._title = _title;
            this._author = _author;
            this._grade = _grade;
            this._minDuration = _minDuration;
            this._weight = _weight;
        }

    }
}
