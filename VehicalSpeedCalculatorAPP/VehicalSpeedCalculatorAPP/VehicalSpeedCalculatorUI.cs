using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicalSpeedCalculatorAPP
{
    public partial class VehicalSpeedCalculatorUI : Form
    {
        public VehicalSpeedCalculatorUI()
        {
            InitializeComponent();
        }

        double aSpeed;
        Vehical speed = new Vehical();
        private void buttonShow_Click(object sender, EventArgs e)
        {
            textBoxmax.Text = speed.Maximum.ToString();
            textBoxMin.Text = speed.Minimum.ToString();
            textBoxAvg.Text = speed.Avarage.ToString();

            textBoxSpeed.Text = "";



        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            aSpeed = Convert.ToDouble(textBoxSpeed.Text);
            
            textBoxSpeed.Text = "";

            speed.Maximum = aSpeed;
            speed.Minimum = aSpeed;
            speed.Avarage = aSpeed;


        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxRegNo.Text = "";

            speed.reset();

         }
    }
}
