using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Library.Business
{/// <summary>
/// Represents a movie.
/// </summary>
    public class Movie
    {

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _title;
        /// <summary>
        /// Run Length in minutes.
        /// </summary>
        public int runLength;

        public string description;

        public int releaseYear = 1900;

        public bool isClassic;
        
    }
}
