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
            if (NamesListBox.SelectedIndex == -1)
            {
                // @todo: Add visual indicator and message regarding name not being selected

                return;
            }

            RemoveNameAt(NamesListBox.SelectedIndex);
        }

    }
}
