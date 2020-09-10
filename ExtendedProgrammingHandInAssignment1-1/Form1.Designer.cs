namespace ExtendedProgrammingHandInAssignment1_1
{
    partial class Form1
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
            this.NamesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeletePositionButton = new System.Windows.Forms.Button();
            this.AddNameButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NamesListBox
            // 
            this.NamesListBox.FormattingEnabled = true;
            this.NamesListBox.ItemHeight = 15;
            this.NamesListBox.Location = new System.Drawing.Point(547, 68);
            this.NamesListBox.Name = "NamesListBox";
            this.NamesListBox.Size = new System.Drawing.Size(216, 319);
            this.NamesListBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(543, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Names:";
            // 
            // DeletePositionButton
            // 
            this.DeletePositionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeletePositionButton.Location = new System.Drawing.Point(118, 233);
            this.DeletePositionButton.Name = "DeletePositionButton";
            this.DeletePositionButton.Size = new System.Drawing.Size(137, 34);
            this.DeletePositionButton.TabIndex = 5;
            this.DeletePositionButton.Text = "Delete";
            this.DeletePositionButton.UseVisualStyleBackColor = true;
            this.DeletePositionButton.Click += new System.EventHandler(this.DeletePositionButton_Click);
            // 
            // AddNameButton
            // 
            this.AddNameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNameButton.Location = new System.Drawing.Point(118, 115);
            this.AddNameButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddNameButton.Name = "AddNameButton";
            this.AddNameButton.Size = new System.Drawing.Size(137, 33);
            this.AddNameButton.TabIndex = 4;
            this.AddNameButton.Text = "Add name";
            this.AddNameButton.UseVisualStyleBackColor = true;
            this.AddNameButton.Click += new System.EventHandler(this.AddNameButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(54, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameInput.Location = new System.Drawing.Point(118, 68);
            this.NameInput.Margin = new System.Windows.Forms.Padding(4);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(378, 29);
            this.NameInput.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(117, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "To delete a name: Select the name and click Delete";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddNameButton);
            this.Controls.Add(this.DeletePositionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NamesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NamesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeletePositionButton;
        private System.Windows.Forms.Button AddNameButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label3;
    }
}

