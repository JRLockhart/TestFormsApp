namespace TestFormsApp
{
    partial class TestFormsApp
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
            this.ChangeText = new System.Windows.Forms.Button();
            this.EnableCheckbox = new System.Windows.Forms.CheckBox();
            this.LabelToChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeText
            // 
            this.ChangeText.Location = new System.Drawing.Point(12, 37);
            this.ChangeText.Name = "ChangeText";
            this.ChangeText.Size = new System.Drawing.Size(179, 23);
            this.ChangeText.TabIndex = 0;
            this.ChangeText.Text = "Change the label if checked";
            this.ChangeText.UseVisualStyleBackColor = true;
            this.ChangeText.Click += new System.EventHandler(this.ChangeText_Click);
            // 
            // EnableCheckbox
            // 
            this.EnableCheckbox.AutoSize = true;
            this.EnableCheckbox.Checked = true;
            this.EnableCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableCheckbox.Location = new System.Drawing.Point(357, 37);
            this.EnableCheckbox.Name = "EnableCheckbox";
            this.EnableCheckbox.Size = new System.Drawing.Size(131, 17);
            this.EnableCheckbox.TabIndex = 1;
            this.EnableCheckbox.Text = "Enabel label changing";
            this.EnableCheckbox.UseVisualStyleBackColor = true;
            // 
            // LabelToChange
            // 
            this.LabelToChange.AutoSize = true;
            this.LabelToChange.Location = new System.Drawing.Point(178, 88);
            this.LabelToChange.Name = "LabelToChange";
            this.LabelToChange.Size = new System.Drawing.Size(171, 13);
            this.LabelToChange.TabIndex = 2;
            this.LabelToChange.Text = "Press the button to change my text";
            this.LabelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestFormsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 130);
            this.Controls.Add(this.LabelToChange);
            this.Controls.Add(this.EnableCheckbox);
            this.Controls.Add(this.ChangeText);
            this.Name = "TestFormsApp";
            this.Text = "TestFormsApp";
            this.Load += new System.EventHandler(this.TestFormsApp.Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangeText;
        private System.Windows.Forms.CheckBox EnableCheckbox;
        private System.Windows.Forms.Label LabelToChange;
    }
}

