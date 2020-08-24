using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE1304_EOS
{
    public partial class AddQuestionScreen : Form
    {
        public AddQuestionScreen()
        {
            InitializeComponent();
        }

        List<AnswerControl> acs = new List<AnswerControl>();

        private void btnMoreAnswer_Click(object sender, EventArgs e)
        {
            AnswerControl ac = new AnswerControl(acs.Count + 1);
            acs.Add(ac);
            pnAnswers.Controls.Add(ac);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            question.id = Convert.ToInt32(txtID.Text);
            question.content = txtContent.Text;
            question.score = float.Parse(txtScore.Text);
            question.duration = Convert.ToInt32(txtDuration.Text);
            foreach(AnswerControl ac in acs)
            {
                question.answers.Add(ac.GetAnswer());
            }
            QuestionDAO db = new QuestionDAO();
            db.insertQuestion(question);
        }
    }
}
