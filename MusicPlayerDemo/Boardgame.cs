using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerDemo
{
    public class Boardgame
    {
        private string title;
        private string description;
        private string author;
        private string duration;
        private double grade;

        public string Title   // property
        {
            get { return title; }   // get method
            set { title = value; }  // set method
        }
        public string Description   // property
        {
            get { return description; }   // get method
            set { description = value; }  // set method
        }
        public string Author   // property
        {
            get { return author; }   // get method
            set { author = value; }  // set method
        }
        public string Duration   // property
        {
            get { return duration; }   // get method
            set { duration = value; }  // set method
        }
        public double Grade   // property
        {
            get { return grade; }   // get method
            set { grade = value; }  // set method
        }

        public Boardgame(string title, string description,  string author, string duration, double grade)
        {
            this.title = title; 
            this.description = description;
            this.author = author; 
            this.duration = duration;
            this.grade = grade;
        }

        //public string getTitle()
        //{
        //    return Title;
        //}

        //public void setTitle(string title)
        //{
        //    this.Title = title;
        //}

        //public string getDescription()
        //{
        //    return Description;
        //}

        //public void setDescription(string description)
        //{
        //    this.Description = description;
        //}

        //public string getAuthor()
        //{
        //    return Author;
        //}

        //public void setAuthor(string author)
        //{
        //    this.Author = author;
        //}

        //public string getDuration()
        //{
        //    return this.Duration;
        //}

        //public void setDuration(string duration)
        //{
        //    this.Duration = duration;
        //}

        //public double getGrade()
        //{
        //    return Grade;
        //}

        //public void setGrade(double grade)
        //{
        //    if(grade < 0 || grade > 10)
        //    {
        //        throw new ArgumentException("Nota inválida.");
        //    }
        //    Grade = grade;
        //}
    }
}
