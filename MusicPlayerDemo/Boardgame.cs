using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerDemo
{
    public class Boardgame
    {
        private string Title;
        private string Description;
        private string Author;
        private string Duration;
        private double Grade;

        public Boardgame(string title, string description,  string author, string duration, double grade)
        {
            Title = title; 
            Description = description;
            Author = author; 
            Duration = duration;
            Grade = grade;
        }

        public string getTitle()
        {
            return Title;
        }

        public void setTitle(string title)
        {
            this.Title = title;
        }

        public string getDescription()
        {
            return Description;
        }

        public void setDescription(string description)
        {
            this.Description = description;
        }

        public string getAuthor()
        {
            return Author;
        }

        public void setAuthor(string author)
        {
            this.Author = author;
        }

        public string getDuration()
        {
            return this.Duration;
        }

        public void setDuration(string duration)
        {
            this.Duration = duration;
        }

        public double getGrade()
        {
            return Grade;
        }

        public void setGrade(double grade)
        {
            if(grade < 0 || grade > 10)
            {
                throw new ArgumentException("Nota inválida.");
            }
            Grade = grade;
        }
    }
}
