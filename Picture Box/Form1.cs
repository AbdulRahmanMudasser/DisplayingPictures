using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // set the filter to allow image files with various extensions
            openFileDialog.Filter = "Image Files | *.jpg; *.jpeg; *.png; *.gif; *.bmp; *.tiff";

            // display the OpenFileDialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get the selected file path
                string imagePath = openFileDialog.FileName;

                // load the image file into the PictureBox control
                pictureBox1.Image = Image.FromFile(imagePath);
            }
        }
    }
}
