using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entity;

namespace SE1304_EOS
{
    public partial class AnswerControl : UserControl
    {
        public AnswerControl(int index)
        {
            InitializeComponent();
            lblIndex.Text = "Answer " + index;
        }

        public AnswerControl(int index,Answer a)
        {
            InitializeComponent();
            lblIndex.Text = "Answer " + index;
        }

        public Answer GetAnswer()
        {
            Answer a = new Answer();
            a.id = Convert.ToInt32(txtID.Text);
            a.content = txtContent.Text;
            a.corrected = cbxCorrect.Checked;
            return a;
        }
    }
}
