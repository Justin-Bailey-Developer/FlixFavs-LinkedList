using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlixFavs
{
    public partial class HomeForm : Form
    {

        Movie movie;
        List<Movie> Movies { get; set; }
        //ListUtil

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            ListUtil.movieList.Append(new Movie(1, "John Wick", 2019, 9.0));
            ListUtil.movieList.Append(new Movie(2, "Avengers", 2020, 8.5));
            ListUtil.movieList.Append(new Movie(3, "Wrath of Man", 2021, 8.0));

            DisplayData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {                        

            int id = Convert.ToInt32(txbID.Text);
            string name = txbTitle.Text;
            int year = Convert.ToInt32(txbYear.Text);
            double rating = Convert.ToDouble(nudRating.Value);

            movie = new Movie(id, name, year, rating);

            ClearFields();

            //MovieNode newNode = new MovieNode(movie);

            ListUtil.movieList.Append(movie);

            DisplayData();

            /*txbOutput.Clear();
            txbOutput.Text += "Size: " + ListUtil.movieList.Size() + Environment.NewLine;
            txbOutput.Text += ListUtil.movieList.ToString();
            txbOutput.Text += "--------------------------------------" + Environment.NewLine;*/

        }

        private void DisplayData()
        {
            txbOutput.Clear();
            txbOutput.Text += "Size: " + ListUtil.movieList.GetSize() + Environment.NewLine;
            txbOutput.Text += ListUtil.movieList.ToString();
            txbOutput.Text += "---------------------------------------------------" + Environment.NewLine;
        }

        private void ClearFields()
        {
            txbID.Clear();
            txbTitle.Clear();
            txbYear.Clear();
            nudRating.ResetText();
        }

        private void btnCarousel_Click(object sender, EventArgs e)
        {

            if (ListUtil.movieList.IsEmpty())
            {
                MessageBox.Show("Add a movie first");
            }
            else
            {
                CarouselForm carouselForm = new CarouselForm();
                this.Hide();
                carouselForm.ShowDialog();
                this.Show();
            }
            
        }
    }
}
