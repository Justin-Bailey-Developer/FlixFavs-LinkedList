using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixFavs
{
    public class Movie
    {

        int ID { get; set; }
        string Name { get; set; }
        int Year { get; set; }
        double Rating { get; set; }

        public Movie (int id, string name, int year, double rating)
        {
            ID = id;
            Name = name;
            Year = year;
            Rating = rating;
        }

        public override string ToString()
        {
            return this.ID + ": " + this.Name + " (" + this.Year + ") - Rating: " + this.Rating;
        }

    }
}
