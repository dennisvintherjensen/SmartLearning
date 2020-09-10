using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedProgrammingHandInAssignment1_1
{
    public partial class Form1 : Form
    {
        private string[] names = new string[10];

        public Form1()
        {
            InitializeComponent();

            MessageLabel.Visible = false;

            MessageLabel.ForeColor = Color.Red;
        }

        /// <summary>
        /// Clears the content of the listbox displaying the names. Then adds 
        /// all elements from the names array which are not null.
        /// </summary>
        private void UpdateListBox()
        {
            NamesListBox.Items.Clear();

            for (int i = 0; i < names.Length; i++)
            {
                if (!string.IsNullOrEmpty(names[i]))
                {
                    NamesListBox.Items.Add($"{i}: {names[i]}");
                }
            }
        }

        /// <summary>
        /// Adds a name to the collection and initializes a UI update.
        /// </summary>
        /// <param name="name"></param>
        private void AddName(string name)
        {
            int firstFreeIndex = Array.IndexOf(names, null);

            if (firstFreeIndex == -1)
            {
                firstFreeIndex = names.Length;

                Array.Resize(ref names, names.Length + 10);
            }

            names[firstFreeIndex] = name;

            UpdateListBox();

            NameInput.Clear();
        }

        /// <summary>
        /// Removes a name from the collection using the specified index.
        /// </summary>
        /// <param name="index"></param>
        private void RemoveNameAt(int index)
        {
            names[index] = null;

            UpdateListBox();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        private void ShowMessage(string message)
        {
            MessageLabel.Visible = true;

            MessageLabel.Text = message;
        }

        /// <summary>
        /// 
        /// </summary>
        private void HideMessage()
        {
            MessageLabel.Visible = false;

            MessageLabel.Text = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNameButton_Click(object sender, EventArgs e)
        {
            HideMessage();

            string name = NameInput.Text;

            if (string.IsNullOrEmpty(name))
            {
                ShowMessage("You need to enter a name.");

                return;
            }

            AddName(name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeletePositionButton_Click(object sender, EventArgs e)
        {
            HideMessage();

            string selectedListItem = NamesListBox.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedListItem))
            {
                ShowMessage("You need to select a name.");

                return;
            }

            string position = selectedListItem.Split(':')[0];

            if (int.TryParse(position, out int index))
            {
                RemoveNameAt(index);
            }
            else
            {
                ShowMessage("An error occurred.");
            }
        }
    }
}
