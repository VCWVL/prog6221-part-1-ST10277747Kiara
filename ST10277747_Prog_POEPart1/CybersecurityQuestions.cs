using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10277747_Prog_POEPart1
{
    public class CybersecurityQuestion
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        // Constructor
        public CybersecurityQuestion(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }
    }
}