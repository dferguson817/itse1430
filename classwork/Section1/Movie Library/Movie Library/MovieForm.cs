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

namespace MovieLibrary.Winforms
{
    public partial class MovieForm : Form
    {
        public MovieForm ()
        {
            InitializeComponent();
        }

        public Movie Movie
        {
            get { return _movie; }
            set { _movie = value; }
        }
        private Movie _movie;


        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }



        private void OnOK ( object sender, EventArgs e )
        {
            //TODO: Validation and error reporting
            var movie = GetMovie();
            if (!ValidateMovie(movie))
                return;
            Movie = movie;
            DialogResult = DialogResult.OK;
            Close();
        }

        private Movie GetMovie ()
        {
            var movie = new Movie();

            movie.Title = txtTITLE.Text?.Trim();
            movie.RunLength = GetAsInt32(txtRUNLENGTH);
            movie.ReleaseYear = GetAsInt32(txtRELEASEYEAR, 1900);
            movie.Description = txtDESCRIPTION.Text.Trim();
            movie.IsClassic = chkIsCLASSIC.Checked;

            return movie;
        }

        private bool ValidateMovie ( Movie movie )
        {
            //Title is required
            //if (txtTitle.Text?.Trim() == "")
            if (String.IsNullOrEmpty(Movie.Title))
            {
                DisplayError("Title is required.");
                return false;
            };

            //Run length >= 0
            if (GetAsInt32(txtRUNLENGTH) < 0)
            {
                DisplayError("Run length must be >= 0.");
                return false;
            };

            //Release year >= 1900
            if (GetAsInt32(txtRELEASEYEAR, 1900) < 1900)
            {
                DisplayError("Release year must be >= 1900.");
                return false;
            };

            return true;
        }
        private int GetAsInt32 ( Control control )
        {
            return GetAsInt32(control, 0);
        }
        private void DisplayError ( string message )
        {
            var that = this;

            //var Text = "";
            //var newTitle = this.Text;
            //var newTitle = Text;
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int GetAsInt32 ( Control control, int emptyValue )
        {
            if (String.IsNullOrEmpty(control.Text))
                return emptyValue;

            if (Int32.TryParse(control.Text, out var result))
                return result;

            return -1;
        }
    }
}

