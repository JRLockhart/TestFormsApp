using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFormsApp
{
    public partial class TestFormsApp : Form
    {
        public TestFormsApp()
        {
            InitializeComponent();
        }

        private void ChangeText_Click(object sender, EventArgs e)
        {
            if (EnableCheckbox.Checked == true)
            {
                if (LabelToChange.Text == "Right")
                {
                    LabelToChange.Text = "Left";
                    LabelToChange.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    LabelToChange.Text = "Right";
                    LabelToChange.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                LabelToChange.Text = "Text changing is disabled";
                LabelToChange.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
