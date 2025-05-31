// LashaMurgvaLominadzeShraieri.Final/Form1.cs
using LashaMurgvaLominadzeShraieri.Final.Models;
using LashaMurgvaLominadzeShraieri.Final.Services;
using System.ComponentModel; // Make sure this is included
using System.Linq;

namespace LashaMurgvaLominadzeShraieri.Final
{
    public partial class Form1 : Form
    {
        private readonly SqlCarService _carService;
        private readonly BindingList<Car> _bindingList;

        public Form1()
        {
            InitializeComponent();
            _carService = new SqlCarService(); // Instantiate the new service
            _bindingList = new BindingList<Car>();
            listBox.DataSource = _bindingList;
            listBox.DisplayMember = "ToString"; // Display the ToString() output in the ListBox

            Sync(); // Load initial data from the database when the form loads
        }

        // Add Button Click Event
        private void addBtn_Click(object sender, EventArgs e)
        {
            CarDialog dialog = new CarDialog(); // Use CarDialog
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Car(
                    dialog.Model,
                    dialog.Weight,
                    dialog.Speed
                );

                _carService.AddCar(car);
                Sync(); // Update the list
            }
        }

        // Edit Button Click Event
        private void editBtn_Click(object sender, EventArgs e)
        {
            // Get the selected Car object directly from the ListBox
            if (listBox.SelectedItem is Car selectedCar)
            {
                CarDialog dialog = new CarDialog(selectedCar); // Use CarDialog
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Update the properties of the selectedCar object
                    selectedCar.Model = dialog.Model;
                    selectedCar.Weight = dialog.Weight;
                    selectedCar.Speed = dialog.Speed;

                    // Pass the updated Car object to the service
                    _carService.UpdateCar(selectedCar);
                    Sync(); // Update the list
                }
            }
            else
            {
                MessageBox.Show("Please select a car to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Delete Button Click Event
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Get the selected Car object directly from the ListBox
            if (listBox.SelectedItem is Car selectedCar)
            {
                // Pass the ID of the selected Car to the service for deletion
                _carService.DeleteCar(selectedCar.ID);
                Sync(); // Update the list
            }
            else
            {
                MessageBox.Show("Please select a car to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Sync the list with updated data
        private void Sync()
        {
            _bindingList.Clear(); // Clear current list
            var cars = _carService.GetCars().ToList(); // Get updated cars from service
            foreach (var car in cars)
            {
                _bindingList.Add(car); // Add each car to the BindingList
            }
        }
    }
}
