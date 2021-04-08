
namespace FinalProjectMDINicholasShortt
{
    partial class formCustomerEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxTitle = new System.Windows.Forms.ComboBox();
            this.checkBoxVip = new System.Windows.Forms.CheckBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.listViewEntries = new System.Windows.Forms.ListView();
            this.columnHeaderVip = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTitle = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFirstName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLastName = new System.Windows.Forms.ColumnHeader();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTitle
            // 
            this.comboBoxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTitle.FormattingEnabled = true;
            this.comboBoxTitle.Items.AddRange(new object[] {
            "",
            "Dr.",
            "Duchess",
            "Duke",
            "Hon.",
            "Lady",
            "Lord",
            "Mr.",
            "Mrs.",
            "Ms.",
            "Mx.",
            "Sir"});
            this.comboBoxTitle.Location = new System.Drawing.Point(268, 18);
            this.comboBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTitle.Name = "comboBoxTitle";
            this.comboBoxTitle.Size = new System.Drawing.Size(224, 38);
            this.comboBoxTitle.TabIndex = 1;
            this.toolTip.SetToolTip(this.comboBoxTitle, "Select the customer\'s title");
            // 
            // checkBoxVip
            // 
            this.checkBoxVip.AutoSize = true;
            this.checkBoxVip.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxVip.Location = new System.Drawing.Point(213, 190);
            this.checkBoxVip.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxVip.Name = "checkBoxVip";
            this.checkBoxVip.Size = new System.Drawing.Size(75, 34);
            this.checkBoxVip.TabIndex = 6;
            this.checkBoxVip.Text = "&VIP:";
            this.toolTip.SetToolTip(this.checkBoxVip, "Select if the customer is a VIP");
            this.checkBoxVip.UseVisualStyleBackColor = true;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(270, 132);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(223, 35);
            this.textBoxLastName.TabIndex = 5;
            this.toolTip.SetToolTip(this.textBoxLastName, "Enter the customer\'s last name");
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(270, 75);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(223, 35);
            this.textBoxFirstName.TabIndex = 3;
            this.toolTip.SetToolTip(this.textBoxFirstName, "Enter the customer\'s first name");
            // 
            // labelLastName
            // 
            this.labelLastName.Location = new System.Drawing.Point(82, 136);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(180, 30);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "&Last Name:";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Location = new System.Drawing.Point(82, 80);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(180, 30);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "&First Name:";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(82, 22);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(180, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "&Title:";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelError
            // 
            this.labelError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelError.Location = new System.Drawing.Point(18, 624);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(537, 128);
            this.labelError.TabIndex = 8;
            this.toolTip.SetToolTip(this.labelError, "Displays all error messages");
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(438, 768);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(115, 44);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "&Close";
            this.toolTip.SetToolTip(this.buttonExit, "Click to exit the application");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(158, 768);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(115, 44);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Click to reset all entry fields");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(18, 768);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(115, 44);
            this.buttonEnter.TabIndex = 9;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Click to enter the current customer");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.ButtonEnterClick);
            // 
            // listViewEntries
            // 
            this.listViewEntries.CheckBoxes = true;
            this.listViewEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderVip,
            this.columnHeaderTitle,
            this.columnHeaderFirstName,
            this.columnHeaderLastName});
            this.listViewEntries.FullRowSelect = true;
            this.listViewEntries.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEntries.HideSelection = false;
            this.listViewEntries.Location = new System.Drawing.Point(18, 236);
            this.listViewEntries.Margin = new System.Windows.Forms.Padding(4);
            this.listViewEntries.MultiSelect = false;
            this.listViewEntries.Name = "listViewEntries";
            this.listViewEntries.Size = new System.Drawing.Size(535, 368);
            this.listViewEntries.TabIndex = 7;
            this.toolTip.SetToolTip(this.listViewEntries, "Display a list of all customers");
            this.listViewEntries.UseCompatibleStateImageBehavior = false;
            this.listViewEntries.View = System.Windows.Forms.View.Details;
            this.listViewEntries.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.PreventCheck);
            this.listViewEntries.SelectedIndexChanged += new System.EventHandler(this.CustomerSelected);
            // 
            // columnHeaderVip
            // 
            this.columnHeaderVip.Text = "VIP?";
            this.columnHeaderVip.Width = 45;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "Title";
            this.columnHeaderTitle.Width = 45;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "First Name";
            this.columnHeaderFirstName.Width = 120;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Last Name";
            this.columnHeaderLastName.Width = 120;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(298, 768);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 44);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "&Save";
            this.toolTip.SetToolTip(this.buttonSave, "Click here to save the list to a text file.");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
            // 
            // formCustomerEntry
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(573, 830);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listViewEntries);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.comboBoxTitle);
            this.Controls.Add(this.checkBoxVip);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(597, 894);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(597, 894);
            this.Name = "formCustomerEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Entry";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerFormClosed);
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTitle;
        private System.Windows.Forms.CheckBox checkBoxVip;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.ListView listViewEntries;
        private System.Windows.Forms.ColumnHeader columnHeaderVip;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonSave;
    }
}