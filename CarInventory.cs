/*
 * Author: Nicholas Shorrtt
 * Last Modified: March 10, 2021
 * Description: 
 *  Create a form to record entries of cars entered into it.  All fields must have 
 *  values and the price must be numeric.  The user will be able to change the
 *  entries by selecting it and change the values in the enty fields
 *  
 * Modified: April 05, 2021
 * Changes:
 *  Fixed the issue of the form not allowing for new entries after selecting 
 *  something from the list.
 *  Added the fuctionallity to change entries of the list.
 *  When moved to function with MDI parent, made it so only one instance of the
 *  form could exist.  If a new one is called the current isntace will be passed
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectMDINicholasShortt
{
    public partial class formCarInventory : System.Windows.Forms.Form
    {


        public formCarInventory()
        {
            InitializeComponent();
        }

        #region "Variables"
        // Hold all cars
        private List<Car> carList = new List<Car>();
        // For allow the form to change list checkbox
        private bool isAutomated = false;
        // Holds the index of the entry you are changing
        private int selectedIndex = -1;
        // Variable created so only one instance will exist
        static formCarInventory instance;
        #endregion

        #region "Event Handler"

        private void FormLoad(object sender, EventArgs e)
        {
            const int NUMBER_OF_YEARS = 100;
            // Fill the year drop down upto the defined constant
            for (int year = DateTime.Today.Year; year >= DateTime.Today.Year - NUMBER_OF_YEARS; year--)
            {
                comboBoxYear.Items.Add(year);
            }
        }

        /// <summary>
        /// When a user trys to check a box in the list view, keep it as it was.
        /// </summary>
        private void PreventCheck(object sender, ItemCheckEventArgs e)
        {
            // Only prevent checking if it is the user
            if (!isAutomated)
            {
                // Make the new value equal to the old value to preven change.
                e.NewValue = e.CurrentValue;

                // Message on attempt to check a box in view list.
                labelResult.Text = "Go away human.";
            }
        }

        /// <summary>
        /// When a car in the list view is select write the car properties into the controls.
        /// </summary>
        private void CarSelected(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Check if there is items in the list and not one selected
            if (listViewEntries.Items.Count > 0 && listViewEntries.FocusedItem != null)
            {         
                // Set the entry fields to the data from the entry
                comboBoxMake.Text = listViewEntries.FocusedItem.SubItems[2].Text;
                textBoxModel.Text = listViewEntries.FocusedItem.SubItems[3].Text;
                comboBoxYear.Text = listViewEntries.FocusedItem.SubItems[4].Text;
                textBoxPrice.Text = listViewEntries.FocusedItem.SubItems[5].Text;

                checkBoxNew.Checked = listViewEntries.FocusedItem.Checked;

                // Set the selectedIndex to match the listView.
                selectedIndex = listViewEntries.FocusedItem.Index;
            }
            else
            {
                // Deselect an entry
                selectedIndex = -1;
            }
        }

        /// <summary>
        /// When the button is click the enter values will attempt to be added to the collection, or
        /// if a car is currently selected a message will display a summary of it's details
        /// </summary>
        private void EnterButton(object sender, EventArgs e)
        {     
            // Clear the label
            labelResult.Text = String.Empty;

            // Decalare varaibles
            double price;
            int year;
                               
            // Check if price is numeric
            if (double.TryParse(textBoxPrice.Text, out price))
            {
                // Validate the entry feilds
                if (IsCarValid(comboBoxMake.Text, textBoxModel.Text.Trim(), comboBoxYear.Text, price))
                {
                    // Pass year entry into an int
                    int.TryParse(comboBoxYear.Text, out year);

                    // Round the price to 2 decimal places
                    price = Math.Round(price, 2);

                    // Check if no car is selected
                    if (selectedIndex < 0)
                    {
                        // Create a car object using parametize constructor
                        Car car = new Car(comboBoxMake.Text, textBoxModel.Text.Trim(), year, price, checkBoxNew.Checked);

                        // Add object to list
                        AddToList(car);
                    }
                    else
                    {
                        // Update the list holding the cars
                        carList[selectedIndex].Make = comboBoxMake.Text;
                        carList[selectedIndex].Model = textBoxModel.Text;
                        carList[selectedIndex].Year = year;
                        carList[selectedIndex].Price = price;
                        carList[selectedIndex].NewStatus = checkBoxNew.Checked;

                        // Update the entry
                        listViewEntries.FocusedItem.SubItems[2].Text = comboBoxMake.Text;
                        listViewEntries.FocusedItem.SubItems[3].Text = textBoxModel.Text;
                        listViewEntries.FocusedItem.SubItems[4].Text = year.ToString();
                        listViewEntries.FocusedItem.SubItems[5].Text = price.ToString("c");

                        isAutomated = true;
                        listViewEntries.FocusedItem.Checked = checkBoxNew.Checked;
                        isAutomated = false;
                    }

                    // Clear entry feilds
                    SetDefaults();
                    // Display success message
                    labelResult.Text = "It worked!";
                }
            }
            else
            {
                // Display error if price is not numeric.
                labelResult.Text += "A price must be entered as a numeric value. Please try again.\n";
            }
                    
        }

        /// <summary>
        /// Reset the form inputs
        /// </summary>
        private void ResetButton(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Close the car inventory form
        /// </summary>
        private void CloseButton(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// When the form is closed release the instance.
        /// </summary>
        private void CarInventoryFormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        #endregion

        #region "Function"

        /// <summary>
        /// Converts the car passed in to a ListViewItem and adds it to listViewEntries
        /// </summary>
        /// <param name="newCar"></param>
        private void AddToList(Car newCar)
        {
            // Create a new list view object
            ListViewItem carItem = new ListViewItem();

            carItem.Checked = newCar.NewStatus;

            // Add the data from the car object to the list view
            carItem.SubItems.Add(newCar.Id.ToString());
            carItem.SubItems.Add(newCar.Make);
            carItem.SubItems.Add(newCar.Model);
            carItem.SubItems.Add(newCar.Year.ToString());
            carItem.SubItems.Add(newCar.Price.ToString("c"));

            // Ensure we can change the check value and add the item
            isAutomated = true;
            listViewEntries.Items.Add(carItem);
            isAutomated = false;

            // Add the car object to the list of cars
            carList.Add(newCar);
        }


        /// <summary>
        /// Reset the form's input fields to their default state.
        /// </summary>
        private void SetDefaults()
        {
            // Reset fields to default state
            listViewEntries.SelectedItems.Clear();
            comboBoxMake.SelectedIndex = -1;
            textBoxModel.Clear();
            comboBoxYear.SelectedIndex = -1;
            textBoxPrice.Clear();
            checkBoxNew.Checked = false;
            labelResult.Text = String.Empty;

            // Deselect entry in list
            selectedIndex = -1;

            // Set the defualt focus
            comboBoxMake.Focus();
        }
        /// <summary>
        /// Validate the car entries
        /// </summary>
        /// <param name="make">Make entry</param>
        /// <param name="model">Model entry</param>
        /// <param name="year">Year entry</param>
        /// <param name="price">Price entry</param>
        /// <returns>Return if the entries are all valid or not</returns>
        private bool IsCarValid(string make, string model, string year, double price)
        {
            bool isValid = true;

            // Check if the make is empty
            if (make == "")
            {
                // Display error message and change to invalid
                labelResult.Text += "A make must be select from the list. Please try again.\n";
                isValid = false;
            }

            // Check if the model is empty
            if (model == "")
            {
                // Display error message and change to invalid
                labelResult.Text += "A model must be entered. Please try again.\n";
                isValid = false;
            }

            // Check if the year is empty
            if (year == "")
            {
                // Display error message and change to invalid
                labelResult.Text += "A year must be select from the list. Please try again.\n";
                isValid = false;
            }

            // Check if the price is negaticce
            if (price < 0)
            {
                // Display error message and change to invalid
                labelResult.Text += "Price cannot be a negative number. Please try again.\n";
                isValid = false;
            }

            return isValid;
        }

        #endregion
        #region "Properties"

        /// <summary>
        /// Creates an instance of the form if one dosn't already exist and returns the instance
        /// </summary>
        public static formCarInventory Instance
        {
            get
            {
                // Check if there is a current instance
                if (instance == null)
                {
                    // If not create one
                    instance = new formCarInventory();
                }

                // Return the instance of the form.
                return instance;
            }
        }

        #endregion

    }
}
