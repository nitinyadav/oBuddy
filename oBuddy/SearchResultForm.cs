using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace oBuddy
{
    public partial class SearchResultForm : Form
    {
        BuildServiceReference.responseInfo response;
        
        public SearchResultForm()
        {
            InitializeComponent();
        }

        public void populate(BuildServiceReference.responseInfo res)
        {
            this.response = res;
            this.textBox1.Text = response.Question;
            for (int i = 1; i <= response.Solution.Length; i++)
            {
                if (i == 1 && (response.Solution[0]!= null))
                    this.textBox2.Text = response.Solution[0].ToString();
                if (i == 2 && (response.Solution[1] != null))
                    this.textBox3.Text = response.Solution[1].ToString();
                if (i == 3 && (response.Solution[2] != null))
                    this.textBox4.Text = response.Solution[2].ToString();
            }
            this.label6.Text = response.Solution.Length.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// To change the question
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }
    }
}
