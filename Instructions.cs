using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mancala_GUI
{
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();

            // shows rules page 1
        }

        /// <summary>
        /// Show rules page 2
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The event</param>
        private void button1_Click(object sender, EventArgs e)
        {
            rulesPage1.Visible = false;

            rulesPage1.Refresh();

            rulesPage2.Visible = true;

            rulesPage2.Refresh();
        }

        /// <summary>
        /// Shows rules page 3
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The event</param>
        private void button2_Click(object sender, EventArgs e)
        {
            rulesPage2.Visible = false;

            rulesPage2.Refresh();

            rulesPage3.Visible = true;

            rulesPage3.Refresh();

        }

        /// <summary>
        /// Closes Instructions form
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The event</param>
        private void button3_Click(object sender, EventArgs e)
        {
            rulesPage3.Visible = false;

            this.Close();
        }
    }
}
