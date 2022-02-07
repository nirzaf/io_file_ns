using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace io_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //System.IO.File.Copy("C:\\temp\\Koala.jpg", "E:\\tuts\\koal2.jpg", true);
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = this.openFileDialog1.FileName;
            System.IO.File.Copy(fn , "E:\\tuts\\koal2.jpg", true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = this.openFileDialog1.FileName;
            //-----------------------------------------
            if (System.IO.File.Exists("E:\\tuts\\koal2.jpg")==true )
            {
                System.IO.File.Delete( "E:\\tuts\\koal2.jpg" );
            }
            //-------------------------------------
            System.IO.File.Move(fn, "E:\\tuts\\koal2.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // System.IO.File.Delete("C:\\temp\\koal2.jpg");
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = this.openFileDialog1.FileName;
            System.IO.File.Delete( fn);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string r;
           r= System.IO.File.Exists("C:\\temp\\koal.jpg").ToString();
            if (r == "True")
            {
                MessageBox.Show("I can see your file!!!!");
            }
            else
            {
                MessageBox.Show("I can't see your file,You lost it!!!!");
            }
          //  MessageBox.Show(r);
        }
    }
}
