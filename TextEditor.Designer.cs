
namespace FinalProjectMDINicholasShortt
{
    partial class formTextEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textboxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textboxInput
            // 
            this.textboxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxInput.Location = new System.Drawing.Point(0, 0);
            this.textboxInput.Multiline = true;
            this.textboxInput.Name = "textboxInput";
            this.textboxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxInput.Size = new System.Drawing.Size(800, 450);
            this.textboxInput.TabIndex = 1;
            // 
            // formTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxInput);
            this.Name = "formTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        internal System.Windows.Forms.TextBox textboxInput;
    }
}

