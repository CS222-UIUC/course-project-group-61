using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//All controls relating to front end
namespace crimeMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e) //Clicking ion crime rating will show how the score is calculated
        {
            //Call backend DLL that shows processing
        }

        public void getData()
        {
            //public method that will call the python DLL and use it to draw the map and display safety rating.
        }
    }
}
