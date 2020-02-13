using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieLibrary.Business;
using MovieLibrary.Winforms;

namespace Movie_Library
{
    public partial class MainForm : Form
    {
       

        public MainForm ()
        {
            InitializeComponent();

            
            var movie = new Movie();
                
            //movie.title = "Jaws";
            //movie.description = movie.title;

            movie = new Movie();

            //DisplayMovie(movie);
            //DisplayMovie(null);
            //DisplayConfirmation("Are you sure?", "Start");
        }

        private bool DisplayConfirmation( string message, string title)
        {
           var result = MessageBox.Show(message,title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            return result == DialogResult.OK;
        }

        /// <summary>
        /// Display an error message
        /// </summary>
        /// <param name="message">Error to display</param>
        private void DisplayError ( string message)
        {
            var that = this;

            //var Text = "";
            //var newTitle = this.Text;
            //var newTitle = Text;
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        void DisplayMovie (Movie movie)
        {
            if (movie == null)
                return;

           // var title = movie.title;
           // movie.description = "Test";

            movie = new Movie();
        }

        private void OnMovieAdd ( object sender, EventArgs e )
        {
            MovieForm child = new MovieForm();

            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            //TODO : Save the Movie
            _movie = child.Movie;
            //child.Show();
        }

        private Movie _movie;


        private void OnMovieDelete ( object sender, EventArgs e )
        {
            //Verify movie
            if (_movie == null)
                return;

            if (!DisplayConfirmation($"Are you sure you want to delete {_movie.Title}?", "Delete"))
                return;

            //TODO: delete
            _movie = null;
         }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var about = new AboutBox();

            about.ShowDialog(this);
        }
    }
}
