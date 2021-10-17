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
    public partial class CarouselForm : Form
    {

        Movie current;

        public CarouselForm()
        {
            InitializeComponent();
        }

        private void CarouselForm_Load(object sender, EventArgs e)
        {
            //LinkedList<Movie>.Node node = 
            current = ListUtil.movieList.getFirst();
            txbCurrent.Text = current.ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           //if(current.Next != null)
           //{
                current = ListUtil.movieList.getNext();
                txbCurrent.Text = current.ToString();
            //}
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //if(current.Previous != null)
            //{
                current = ListUtil.movieList.getPrevious();
                txbCurrent.Text = current.ToString();
            //}
        }

        private void btnLucky_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int index = r.Next(0, ListUtil.movieList.GetSize());
            MessageBox.Show("Index: " + index + " - Movie Data: " + ListUtil.movieList[index].ToString());
        }
    }
}
