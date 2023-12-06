using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SignIn signin = new SignIn();
        private void button1_Click(object sender, EventArgs e)
        {
            using (var Form2 = new Form2())
            {
                // Set any properties or pass data to the VideosForm if needed

                // Show the VideosForm as a dialog
                Form2.ShowDialog(this);
            }
        }

        
    }
}
