using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Question
    {
        public int id { get; set; }
        public string content { get; set; }
        public float score { get; set; }
        public int duration { get; set; }
        public List<Answer> answers = new List<Answer>();

        public bool multipleChoice
        {
            get
            {
                int count = 0;
                foreach(Answer a in answers)
                {
                    if(a.corrected)
                    {
                        count++;
                    }
                }
                return count > 1;
            }
        }

    }

    public class Answer
    {
        public int id { get; set; }
        public string content { get; set; }
        public bool corrected { get; set; }
    }
}
