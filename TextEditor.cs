/*
 * Author: Nicholas Shorrtt
 * Last Modified: March 22, 2021
 * Description: 
 *  Simple text editor program.  Several basic options and a menu strip where included
 *  Options like cut, copy, and paste for editing text.  The user can save and open text 
 *  files as well as create new ones.
 * 
 * Modified: April 05, 2021
 * Changes:
 * Removed the OpenClick, and NewClick events
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
    public partial class formTextEditor : Form
    {
        // Varaible
        string filePath = string.Empty;

        public formTextEditor()
        {
            InitializeComponent();
        }

        #region "Event"

        /// <summary>
        /// Copies selected text, if any, to clipboard
        /// </summary>
        internal void CopyClick(object sender, EventArgs e)
        {
            // Checks if there is any text selected
            if (textboxInput.SelectedText.Length != 0)
            {
                // Copy selected text to clipboard
                Clipboard.SetText(textboxInput.SelectedText);
            }
        }

        /// <summary>
        /// Copies selected text, if any, to clipboard and removes it from textbox
        /// </summary>
        internal void CutClick(object sender, EventArgs e)
        {
            // Checks if there is any text selected
            if (textboxInput.SelectedText.Length != 0)
            {
                // Copy selected text to clipboard
                Clipboard.SetText(textboxInput.SelectedText);

                // Delete selected text
                textboxInput.SelectedText = "";
            }
        }

        /// <summary>
        /// Appends clipboard text, if any, to where cursor  is currently in textbox
        /// </summary>
        internal void PasteClick(object sender, EventArgs e)
        {
            // Check if clipboard has text saved
            if (Clipboard.ContainsText())
            {
                // Check for higlighted text
                if (textboxInput.SelectedText.Length != 0)
                {
                    // Delete selected text
                    textboxInput.SelectedText = "";
                }

                // Appends text in clipboard to the current position of the cursor
                textboxInput.Text = textboxInput.Text.Insert(textboxInput.SelectionStart, Clipboard.GetText());                
            }
        }

        /// <summary>
        /// Calls the save function if there is a file path, if not call the SaveAsClick event
        /// </summary>
        internal void SaveClick(object sender, EventArgs e)
        {
            // if there is a file path
            if (!(filePath == string.Empty))
            {
                // Call Save function
                SaveFile();
            }
            else
            {
                // Call save as event
                SaveAsClick(sender, e);
            }
        }

        /// <summary>
        /// Open a save dialoge box to create file path, and if accepted update title and call Save function
        /// </summary>
        internal void SaveAsClick(object sender, EventArgs e)
        {
            // Create a new save dialoge
            SaveFileDialog saveFile = new SaveFileDialog();

            // Set the file filters
            saveFile.Filter = "Text files (*.txt)|*.txt|All files(*.*)|*.*";

            // When OK is pressed
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                // Set file path and update title
                filePath = saveFile.FileName;
                UpdateTitle(filePath);

                // Call save function
                SaveFile();
            }
        }


        /// <summary>
        /// Close the program
        /// </summary>
        internal void ExitClick(object sender, EventArgs e)
        {
            if (ConfirmClose())
            {
                Close();
            }
        }


        #endregion

        #region "Functions"

        /// <summary>
        /// Updates the forms title to include file path, if any.
        /// </summary>
        public void UpdateTitle(string path)
        {
            // Set the standard title
            this.Text = "Text Editor";

            // If the is a filepath
            if (path != string.Empty)
            {
                // Add the file path to the title
                this.Text += " - " + path;
                filePath = path;
            }
        }

        /// <summary>
        /// Save the text in the texbox to a file.
        /// </summary>
        public void SaveFile()
        {
            // Create the file and write streams
            FileStream fileToAccess = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileToAccess);

            // Append the list entry to the file
            writer.Write(textboxInput.Text);

            // Close the write stream
            writer.Close();
        }

        public bool ConfirmClose()
        {
            // Create a variable for continuing action
            bool confirm = true;

            // Check for a file path
            if (filePath == string.Empty)
            {
                // If no path check if there is any text
                if (textboxInput.Text.Length != 0)
                {
                    // Ask user if they wish to save and save response
                    DialogResult result = MessageBox.Show("Do you wish to save.", "Save?", MessageBoxButtons.YesNoCancel);

                    // Check response
                    if (result == DialogResult.Yes)
                    {
                        // Run save event if yes
                        SaveAsClick(this, null);
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // Change confirm to false if cancel
                        confirm = false;
                    }                    
                }
            }
            else
            {
                // If there is a file path

                // Create the file and read streams
                FileStream fileToAccess = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fileToAccess);

                // Check if the current text is different to the saved text
                if (textboxInput.Text != reader.ReadToEnd())
                {
                    // Ask user if they wish to save and save response
                    DialogResult result = MessageBox.Show("Do you wish to save.", "Save?", MessageBoxButtons.YesNoCancel);

                    // Check response
                    if (result == DialogResult.Yes)
                    {
                        // Close stream here as issues will occure if not done before save function creates one
                        reader.Close();
                        // Call save function
                        SaveFile();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // Change confirm to false if cancel
                        confirm = false;
                    }
                }

                // Close the reader stream
                reader.Close();
            }

            return confirm;
        }

        #endregion


    }
}
