using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iNOXDataSet.Actors' table. You can move, or remove it, as needed.
            this.actorsTableAdapter.Fill(this.iNOXDataSet.Actors);
            // TODO: This line of code loads data into the 'iNOXDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.iNOXDataSet.Movies);

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            this.moviesBindingSource.MoveNext();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.moviesBindingSource.MovePrevious();
        }
   private void newMovie_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void newCast_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void castbackbtn_Click(object sender, EventArgs e)
        {
            this.actorsBindingSource.MovePrevious();
        }

        private void castnextbtn_Click(object sender, EventArgs e)
        {
            this.actorsBindingSource.MoveNext();
        }
    }
}
