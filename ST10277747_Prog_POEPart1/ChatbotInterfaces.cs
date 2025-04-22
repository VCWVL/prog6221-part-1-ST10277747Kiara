using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ST10277747_Prog_POEPart1
{
    public class ChatbotInterface
    {
        private readonly Chatbot _chatbot;
        private string _name; // Backing field for Name

        // Public property with validation in the setter
        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");

                if (!Regex.IsMatch(value, @"^[A-Za-z]+$"))
                    throw new ArgumentException("Name must only contain alphabetical letters.");

                _name = CapitalizeFirstLetter(value);
            }
        }

        // Constructor
        public ChatbotInterface()
        {
            _chatbot = new Chatbot();
        }

        // Capitalize first letter
        private string CapitalizeFirstLetter(string name)
        {
            if (string.IsNullOrEmpty(name))
                return name;
            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }

        // Method to generate answer
        public string GenerateAnswer(string question)
        {
            return _chatbot.GenerateAnswer(question, Name);
        }
    }
}
