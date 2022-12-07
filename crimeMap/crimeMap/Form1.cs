using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

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
            
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/"); //Query google maps
                
                webBrowser1.Navigate(queryaddress.ToString());
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
            
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private void button2_Click(object sender, EventArgs e) //Display open layers content
        {
            /*
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process proc = System.Diagnostics.Process.Start(od.FileName);
                proc.WaitForInputIdle();

                while (proc.MainWindowHandle == IntPtr.Zero)
                {
                    System.Threading.Thread.Sleep(100);
                    proc.Refresh();
                }
                SetParent(proc.MainWindowHandle, this.Handle);
            }
            */
            System.Diagnostics.Process proc = System.Diagnostics.Process.Start("C:\\Users\\Aadarsh Hegde\\Documents\\College Files\\CrimeRating\\course-project-group-61\\map_api\\openlayers.html");
            //Console.WriteLine(@"file://C:\openlayers.html");
        }

        private void search_Click(object sender, EventArgs e)
        {
            /*
            string street = txt_street.Text;
            string city = txt_city.Text;
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/"); //Query google maps
                
                if (street != string.Empty)
                {
                    queryaddress.Append(street + ",+IL");
                }
                if (city != string.Empty)
                {
                    queryaddress.Append(city);
                }
                
                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
            */
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
