using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedProgrammingHandInAssignment1_2
{
    public partial class Form1 : Form
    {
        private List<string> names = new List<string>();
        private BindingSource listDataSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            MessageLabel.Visible = false;

            MessageLabel.ForeColor = Color.Red;

            listDataSource.DataSource = names;

            NamesListBox.DataSource = listDataSource;
        }

        /// <summary>
        /// Adds a name to the collection and initializes a UI update.
        /// </summary>
        /// <param name="name"></param>
        private void AddName(string name)
        {
            names.Add(name);

            NameInput.Clear();

            listDataSource.ResetBindings(false);
        }

        /// <summary>
        /// Removes a name from the collection using the specified index
        /// and initializes a UI update.
        /// </summary>
        /// <param name="index"></param>
        private void RemoveNameAt(int index)
        {
            names.RemoveAt(index);

            listDataSource.ResetBindings(false);
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

            if (NamesListBox.SelectedIndex == -1)
            {
                ShowMessage("You need to select a name.");

                return;
            }

            RemoveNameAt(NamesListBox.SelectedIndex);
        }

    }
}
