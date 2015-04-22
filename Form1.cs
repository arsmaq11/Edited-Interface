using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blue
{
    public partial class text2image : Form
    {
        public text2image()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = ofd.FileName;
                MessageBox.Show(path);
                Image img = Image.FromFile(path);
                PictureBox PictureBox1 = new PictureBox();

                PictureBox1.Image = img;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = ofd.FileName;
                MessageBox.Show(path);
                Image img = Image.FromFile(path);
                PictureBox PictureBox1 = new PictureBox();

                PictureBox1.Image = img;

            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listview2 = new ListView();
            listview2.Show();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }






    }

}