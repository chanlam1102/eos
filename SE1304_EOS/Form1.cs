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
    public partial class Form1 : Form
    {
        List<Question> questions;
        List<Button> question_buttons = new List<Button>();
        List<QuestionControl> question_controls = new List<QuestionControl>();

        int ReamainingTime = 0;

        public Form1()
        {
            InitializeComponent();
            QuestionDAO db = new QuestionDAO();
            questions = db.getQuestions();
            for(int i=0;i<questions.Count;i++)
            {
                Button btnButtonQuestion = new Button();
                btnButtonQuestion.Text = (i + 1).ToString();
                pnQuestionButtons.Controls.Add(btnButtonQuestion);
                question_buttons.Add(btnButtonQuestion);
                btnButtonQuestion.BackColor = Color.White;
                btnButtonQuestion.Click += BtnButtonQuestion_Click;
                QuestionControl qc = new QuestionControl(questions[i],this);
                question_controls.Add(qc);
                ReamainingTime += questions[i].duration;
            }
            displayQuestionControl(question_controls[0]);
            counterDown.Enabled = true;
            displayRemainingTime();
            numericUpDown1.Maximum = 100;
        }

        public void markQuestionAsAsnwered(Question q, bool isMarked)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                if(questions[i] == q)
                {
                    if(isMarked)
                    {
                        question_buttons[i].BackColor = Color.Green;
                    }
                    else
                    {
                        question_buttons[i].BackColor = Color.White;
                    }
                }
            }

        }

        private void BtnButtonQuestion_Click(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            for(int i=0;i< question_buttons.Count;i++)
            {
                if(question_buttons[i] == current)
                {
                    displayQuestionControl(question_controls[i]);
                    return;
                }
            }
        }

        private void displayQuestionControl(QuestionControl qc)
        {
            pnQuestionControl.Controls.Clear();
            pnQuestionControl.Controls.Add(qc);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            finish();
        }

        private void finish()
        {
            List<bool[]> useranswers = new List<bool[]>();
            float total = 0;
            for(int i=0;i< question_controls.Count;i++)
            {
                bool[] result = new bool[questions[i].answers.Count];
                if(question_controls[i].getResult(result))
                {
                    total += questions[i].score;
                }
                useranswers.Add(result);
            }
            counterDown.Enabled = false;
            ResultDialog rd = new ResultDialog(questions, useranswers, total);
            rd.ShowDialog();

        }

        private void counterDown_Tick(object sender, EventArgs e)
        {
            ReamainingTime--;
            displayRemainingTime();
            if (ReamainingTime <= 0)
            {
                
                finish();
            }
        }

        private void displayRemainingTime()
        {
            int hour = ReamainingTime / 3600;
            int minute = (ReamainingTime % 3600) / 60;
            int second = ReamainingTime % 60;
            lblTime.Text = hour + ":" + minute + ":" + second;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuestionScreen a = new AddQuestionScreen();
            a.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value > numericUpDown1.Maximum)
            {
                MessageBox.Show("dcmm");
            }
        }
    }
}
