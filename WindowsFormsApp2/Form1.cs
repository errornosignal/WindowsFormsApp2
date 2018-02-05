using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculates the volume of a sphere.
        /// </summary>
        /// <param name="radius">The length of the radius.</param>
        /// <returns>
        /// The volume of a sphere with the given radius.
        /// </returns>
        public double Volume(double radius)
        {
            var volume = (4.0 / 3.0) * Math.PI * (Math.Pow(radius, 3));
            return volume;
        }

        /// <summary>
        /// Calculates the volume of and Ellipsoid
        /// </summary>
        /// <param name="radA">The length of radius A.</param>
        /// <param name="radB">The length of radius B.</param>
        /// <param name="radC">The length of radius C.</param>
        /// <returns>
        /// Thevolumeof and Ellipsoid with thegiven radii.
        /// </returns>
        public double Volume(double radA, double radB, double radC)
        {
            var volume = (4.0 / 3.0) * Math.PI * (radA * radB * radC);
            return volume;
        }

        /// <summary>
        /// Handles the clik event for the Calculate Button.
        /// </summary>
        /// <param name="sender">
        /// The control that generates the event.
        /// </param>
        /// <param name="e">
        /// The Event Arguments instance that contains event date.
        /// </param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            var radius = double.Parse(this.radiusTextBox.Text);
            var volume = this.Volume(radius);
            this.volumeTextBox.Text = $"{volume:F2}";
        }

        private void calculateButton2_Click(object sender, EventArgs e)
        {
            var radA = double.Parse(this.RadiusATextBox.Text);
            var radB = double.Parse(this.RadiusBTextBox.Text);
            var radC = double.Parse(this.RadiusCTextBox.Text);
            var volume = this.Volume(radA, radB,radC);
            this.volumeTextBox.Text = $"{volume:F2}";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
