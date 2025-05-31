using LashaMurgvaLominadzeShraieri.Final.Models;
using System;
using System.Windows.Forms;

namespace LashaMurgvaLominadzeShraieri.Final
{
    public partial class CarDialog : Form
    {
        public string Model { get; private set; }
        public double Weight { get; private set; }
        public int Speed { get; private set; }

        public CarDialog()
        {
            InitializeComponent();
        }

        public CarDialog(Car car) : this()
        {
            ModelTextBox.Text = car.Model;
            WeightTextBox.Text = car.Weight.ToString();
            SpeedTextBox.Text = car.Speed.ToString();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            // Validate Model
            if (string.IsNullOrWhiteSpace(ModelTextBox.Text))
            {
                MessageBox.Show("Please enter a car model.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Model = ModelTextBox.Text;

            // Validate Weight
            if (!double.TryParse(WeightTextBox.Text, out double weight))
            {
                MessageBox.Show("Please enter a valid weight.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Weight = weight;

            // Validate Speed
            if (!int.TryParse(SpeedTextBox.Text, out int speed))
            {
                MessageBox.Show("Please enter a valid speed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Speed = speed;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
