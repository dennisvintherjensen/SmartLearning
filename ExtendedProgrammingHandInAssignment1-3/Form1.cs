using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedProgrammingHandInAssignment1_3
{
    public partial class Form1 : Form
    {
        private List<string> names = new List<string>();
        private BindingSource listDataSource = new BindingSource();
        private SortOrder sortOrder = SortOrder.Ascending;
        
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

            UpdateDataSourceAndBindings();
        }

        /// <summary>
        /// Removes a name from the collection using the specified index
        /// and initializes a UI update.
        /// </summary>
        /// <param name="index"></param>
        private void RemoveNameAt(int index)
        {
            names.RemoveAt(index);

            UpdateDataSourceAndBindings();
        }

        /// <summary>
        /// Sorts names and refreshes control bindings
        /// </summary>
        private void UpdateDataSourceAndBindings()
        {
            switch (sortOrder)
            {
                // @todo: look into culture used when sorting - å is sorted next to a in english
                case SortOrder.Descending:
                    names.Sort((a, b) => b.CompareTo(a));
                    break;
                default:
                    names.Sort((a, b) => a.CompareTo(b));
                    break;
            }

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

        private void SortDesc_Click(object sender, EventArgs e)
        {
            sortOrder = SortOrder.Descending;

            UpdateDataSourceAndBindings();
        }

        private void SortAsc_Click(object sender, EventArgs e)
        {
            sortOrder = SortOrder.Ascending;

            UpdateDataSourceAndBindings();
        }
    }
}
