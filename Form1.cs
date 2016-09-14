using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnoSoftCW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = WrapString.WrapToLength(this.txtInput.Text,
                                                   System.Convert.ToInt32(this.nLength.Value));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtExpectedResult.Text = this.txtExpectedResult.Text.Replace(@"\n", System.Environment.NewLine);
        }

        private void btnNoWordSplit_Click(object sender, EventArgs e)
        {
            this.txtResult.Text = WrapString.WrapToLength(this.txtInput.Text,
                                                   System.Convert.ToInt32(this.nLength.Value),false);
        }
    }
}
