using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //as you move the marker, display a tooltip with the current value of the track bar 
            toolTip1.SetToolTip(trackBar1,trackBar1.Value.ToString());
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //as you move the marker, display a tooltip with the current value of the track bar 
            toolTip1.SetToolTip(trackBar2, trackBar2.Value.ToString());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (checkedListBox1.SelectedIndex) //used to examine selected index of entry in box
            {
                case 0://case label that corresponds to first item selected, or Add
                    label1.Text =Add (trackBar1.Value , trackBar2.Value).ToString();
                    break;
                case 1://examine weather the word value is selected
                    label1.Text = Divide(trackBar1.Value , trackBar2.Value).ToString();//divide values and display
                    break;
                    
            }
        }
        //private accessible only in our code
        //static means we will be able to call our method just by typing its name
        //double is the type of data by method
        //name of method is Add
        //double x and double y are parameters
        //=> is called "expression bodied member" notation
        private static double Add(double x, double y) => x + y;

        private static double Divide(double x, double y)
        {
            //in math, division by 0 is not allowed: 5/0
            // if y is not 0, divide x by y and send that back to calling code
            // if y is 0, retturn 0.00 to the calling code because division by 0 is not defined
            return (y != 0 )? x / y : 0.0;
        }
    }
}
