using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedProgrammingHandInAssignment1
{
    public partial class Form1 : Form
    {
        private string[] names = new string[10];

        public Form1()
        {
            InitializeComponent();
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
                    NamesListBox.Items.Add($"Pos. {i}: {names[i]}");
                }
            }

            // Could also be done using LINQ:
            // NamesListBox.Items.AddRange(names.Where(name => !string.IsNullOrEmpty(name)).ToArray());
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
            bool positionIsWithinBounds = index >= 0 && index <= names.Length - 1;

            if (positionIsWithinBounds)
            {
                names[index] = null;

                UpdateListBox();
            }

            PositionInput.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNameButton_Click(object sender, EventArgs e)
        {
            string name = NameInput.Text;

            if (string.IsNullOrEmpty(name))
            {
                // @todo: Add visual indicator and message regarding empty name input
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
            string position = PositionInput.Text;

            if (int.TryParse(position, out int index))
            {
                RemoveNameAt(index);
            }
            else
            {
                // @todo: Add visual indicator and message regarding empty name input
            }
        }
    }
}
