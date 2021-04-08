/*
 * Author: Nicholas Shorrtt
 * Last Modified: April 04, 2021
 * Description: 
 * A form used to open new forms inside it's window.  With it you will be 
 * able to open TextEditor forms, CustomerEntry form, CarInventory form, and
 * AvergeUnitsShipped form.  Some events may be called or fuctionally have been
 * moved to this parent form's menu strip.
 *  
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
using System.IO;

namespace FinalProjectMDINicholasShortt
{
    public partial class formMDIParent : Form
    {

        public formMDIParent()
        {
            InitializeComponent();
        }

        #region "Events"

        /// <summary>
        /// Create a new child instance of Average Units form and display it
        /// </summary>
        private void ClickNewAverageUnits(object sender, EventArgs e)
        {
            // Get the current instance of the AverageUnits form or create a new one if not there
            formAverageUnitsShippedByEmployee averageUnits = formAverageUnitsShippedByEmployee.Instance;

            // Assign it's MDI parent to be the form this event was called in
            averageUnits.MdiParent = this;

            // Dispaly the form and set it as the focus
            averageUnits.Show();
            averageUnits.Focus();
        }

        /// <summary>
        /// Create a new child instance of Car Inventory form and display it
        /// </summary>
        private void ClickNewCarList(object sender, EventArgs e)
        {
            // Get the current instance of the CarInventory form or create a new one if not there
            formCarInventory carList =  formCarInventory.Instance;

            // Assign it's MDI parent to be the form this event was called in
            carList.MdiParent = this;

            // Dispaly the form and set it as the focus
            carList.Show();
            carList.Focus();
        }

        /// <summary>
        /// Open a existing Customer List or create a new one, and give it focus.
        /// </summary>
        private void ClickNewCustomerList(object sender, EventArgs e)
        {
            // Get the current instance of the CustomerEntry form or create a new one if not there
            formCustomerEntry customerList = formCustomerEntry.Instance;

            // Assign it's MDI parent to be the form this event was called in
            customerList.MdiParent = this;

            // Dispaly the form and give focus
            customerList.Show();
            customerList.Focus();
        }

        /// <summary>
        /// Create a new child instance of Text Editor when clicked
        /// </summary>
        private void ClickNewTextEditor(object sender, EventArgs e)
        {
            CreateTextEditor();
        }

        /// <summary>
        /// On click change the layout of all child forms to cascade order.
        /// </summary>
        private void ClickCascadeOrder(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        /// <summary>
        /// On click change the layout of all child forms to horizontal order.
        /// </summary>
        private void ClickHorizontalOrder(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        /// <summary>
        /// On click change the layout of all child forms to vertical order.
        /// </summary>
        private void ClickVerticalOrder(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        /// <summary>
        /// Run the copy event of TextEditor form when one is the active child form
        /// </summary>
        private void ClickCopy(object sender, EventArgs e)
        {
            // Check to see if the active child is a TextEditor form.
            if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
            {
                // Create an instance of the child
                formTextEditor textEditor = (formTextEditor)this.ActiveMdiChild;

                // Call the Copy event of Text Editor forms
                textEditor.CopyClick(sender, e);
            }
        }

        /// <summary>
        /// Run the cut event of TextEditor form when one is the active child form
        /// </summary>
        private void ClickCut(object sender, EventArgs e)
        {
            // Check to see if the active child is a TextEditor form.
            if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
            {
                // Create an instance of the child
                formTextEditor textEditor = (formTextEditor)this.ActiveMdiChild;

                // Call the Cut event of Text Editor forms
                textEditor.CutClick(sender, e);
            }
        }

        /// <summary>
        /// Run the paste event of TextEditor form when one is the active child form
        /// </summary>
        private void ClickPaste(object sender, EventArgs e)
        {
            // Check to see if the active child is a TextEditor form.
            if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
            {
                // Create an instance of the child
                formTextEditor textEditor = (formTextEditor)this.ActiveMdiChild;

                // Call the Paste event of Text Editor forms
                textEditor.PasteClick(sender, e);
            }
        }

        /// <summary>
        /// Prompt user to select a text file to open and open it in a new TextEditor instance
        /// </summary>
        private void ClickOpenFile(object sender, EventArgs e)
        {
            // Create a new open dialoge
            OpenFileDialog openFile = new OpenFileDialog();

            // Set the file filters
            openFile.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";

            // When OK is pressed
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Create a new instance of TextEditor
                CreateTextEditor();

                // Copy the instance of newly created Texteditor
                formTextEditor textEditor = (formTextEditor)this.ActiveMdiChild;
                            
                string filePath = openFile.FileName;

                textEditor.UpdateTitle(filePath);

                // Create the file and read streams
                FileStream fileToAccess = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fileToAccess);

                // Fill the textbox with the files contents
                textEditor.textboxInput.Text = reader.ReadToEnd();

                // Close the read stream
                reader.Close();
            }

        }

        /// <summary>
        /// Run the save event of TextEditor form when one is the active child form to save the form
        /// </summary>
        private void ClickSave(object sender, EventArgs e)
        {
            // Check to see if the active child is a TextEditor form.
            if (this.MdiChildren.Length > 0 && this.ActiveMdiChild.GetType() == typeof(formTextEditor))
            {
                // Create an instance of the child
                formTextEditor textEditor = (formTextEditor)this.ActiveMdiChild;

                // Call the Paste event of Text Editor forms
                textEditor.SaveClick(sender, e);
            }
        }

        private void ClickSaveAs(object sender, EventArgs e)
        {
            // Check to see if the active child is a TextEditor form.
            if (this.MdiChildren.Length > 0 && this.ActiveMdiChild.GetType() == typeof(formTextEditor))
            {
                // Create an instance of the child
                formTextEditor textEditor = (formTextEditor)this.ActiveMdiChild;

                // Call the Paste event of Text Editor forms
                textEditor.SaveAsClick(sender, e);
            }
        }

        /// <summary>
        /// Run the save as event of TextEditor form when one is the active child form to save the form with a new name
        /// </summary>
        private void ClickExit(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Close the current active child form or if no children close the parent form
        /// </summary>
        private void ClickClose(object sender, EventArgs e)
        {
            // Check for any children
            if (this.MdiChildren.Length > 0)
            {
                // Check if the active child is a TextEditor
                if (this.ActiveMdiChild.GetType() == typeof(formTextEditor))
                {
                    // Copy the instance of the child
                    formTextEditor textEditor = (formTextEditor)this.ActiveMdiChild;

                    // Call the exit event of Text Editor to close the TextEditor
                    textEditor.ExitClick(sender, e);
                }
                else
                {
                    // Close the active child
                    this.ActiveMdiChild.Close();
                }
            }
            else 
            {
                // Close the parent form
                Close();
            }
        }

        /// <summary>
        /// Display a message box with information on the program
        /// </summary>
        private void ClickAbout(object sender, EventArgs e)
        {
            MessageBox.Show("NETD-2202\n" + "\nFinal Lab\n" + "\nNicholas Shortt", "About");
        }

        #endregion

        #region "Functions"

        /// <summary>
        /// Create a new TextEditor and display it
        /// </summary>
        public void CreateTextEditor()
        {
            // Create a new instance of the text editor form
            formTextEditor textEditor = new formTextEditor();

            // Assign it's MDI parent to be the form this event was called in
            textEditor.MdiParent = this;

            // Dispaly the form and set it as focus
            textEditor.Show();
            textEditor.Focus();
        }

        #endregion


    }
}
