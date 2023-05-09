using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxListingNonStringObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Car myCar = new Car();
            myCar.Name = "Kulpots Ride";
            myCar.BodyColor = Color.Black;
            myCar.IsSedan = false;
            myCar.TopSpeed = 250;

            Car momCar = new Car();
            momCar.Name = "Moms Junker";
            momCar.BodyColor = Color.Red;
            momCar.IsSedan = true;
            momCar.TopSpeed = 200;

            Car broCar = new Car();
            broCar.Name = "Bro junker";
            broCar.BodyColor = Color.Yellow;
            broCar.IsSedan = true;
            broCar.TopSpeed = 400;

            listBox1.Items.Add(myCar);
            listBox1.Items.Add(momCar);
            listBox1.Items.Add(broCar);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car car = (Car)listBox1.SelectedItem;

            lblColor.Text = lblColor.Tag + car.BodyColor.ToString();
            lblSedan.Text = lblSedan.Tag + car.IsSedan.ToString();
            lblTopSpeed.Text = lblTopSpeed.Tag + car.TopSpeed.ToString();
        }
    }
}
