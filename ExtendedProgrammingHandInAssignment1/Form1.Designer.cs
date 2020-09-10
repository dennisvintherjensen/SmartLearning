namespace ExtendedProgrammingHandInAssignment1
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
            this.PositionInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddNameButton = new System.Windows.Forms.Button();
            this.DeletePositionButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NamesListBox = new System.Windows.Forms.ListBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PositionInput
            // 
            this.PositionInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PositionInput.Location = new System.Drawing.Point(128, 192);
            this.PositionInput.Margin = new System.Windows.Forms.Padding(4);
            this.PositionInput.Name = "PositionInput";
            this.PositionInput.Size = new System.Drawing.Size(137, 29);
            this.PositionInput.TabIndex = 0;
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameInput.Location = new System.Drawing.Point(128, 66);
            this.NameInput.Margin = new System.Windows.Forms.Padding(4);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(378, 29);
            this.NameInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Position:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AddNameButton
            // 
            this.AddNameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddNameButton.Location = new System.Drawing.Point(128, 113);
            this.AddNameButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddNameButton.Name = "AddNameButton";
            this.AddNameButton.Size = new System.Drawing.Size(137, 33);
            this.AddNameButton.TabIndex = 4;
            this.AddNameButton.Text = "Tilføj navn";
            this.AddNameButton.UseVisualStyleBackColor = true;
            this.AddNameButton.Click += new System.EventHandler(this.AddNameButton_Click);
            // 
            // DeletePositionButton
            // 
            this.DeletePositionButton.Location = new System.Drawing.Point(128, 239);
            this.DeletePositionButton.Name = "DeletePositionButton";
            this.DeletePositionButton.Size = new System.Drawing.Size(137, 34);
            this.DeletePositionButton.TabIndex = 5;
            this.DeletePositionButton.Text = "Delete position";
            this.DeletePositionButton.UseVisualStyleBackColor = true;
            this.DeletePositionButton.Click += new System.EventHandler(this.DeletePositionButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(553, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Names:";
            // 
            // NamesListBox
            // 
            this.NamesListBox.FormattingEnabled = true;
            this.NamesListBox.ItemHeight = 21;
            this.NamesListBox.Location = new System.Drawing.Point(557, 66);
            this.NamesListBox.Name = "NamesListBox";
            this.NamesListBox.Size = new System.Drawing.Size(216, 319);
            this.NamesListBox.TabIndex = 8;
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(64, 331);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 21);
            this.MessageLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 463);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.NamesListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeletePositionButton);
            this.Controls.Add(this.AddNameButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.PositionInput);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PositionInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddNameButton;
        private System.Windows.Forms.Button DeletePositionButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox NamesListBox;
        private System.Windows.Forms.Label MessageLabel;
    }
}

