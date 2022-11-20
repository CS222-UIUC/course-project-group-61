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
        public void getData()
        {
            //public method that will call the python DLL and use it to draw the map and display safety rating.
            
        }

        private void search_data_Click(object sender, EventArgs e)
        {
            string street = txt_street.Text;
            string city = txt_city.Text;
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/"); //Query google maps
                /*
                if (street != string.Empty)
                {
                    queryaddress.Append(street + ",+");
                }
                if (city != string.Empty)
                {
                    queryaddress.Append(city);
                }
                */
                webBrowser1.Navigate(queryaddress.ToString());
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
    }
}
