using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10277747_Prog_POEPart1
{
    public class Chatbot
    {
        private readonly Dictionary<List<string>, (string, List<string>, ConsoleColor)> responses = new Dictionary<List<string>, (string, List<string>, ConsoleColor)>
        {
            { new List<string> { "cybersecurity" },
                ("Cybersecurity refers to protecting systems, networks, and data from digital attacks or unauthorized access.",
                new List<string> {
                    "Use firewalls to monitor incoming and outgoing traffic.",
                    "Keep software updated to patch security vulnerabilities.",
                    "Use encryption to protect sensitive data." }, ConsoleColor.Cyan) },

            { new List<string> { "common cyberattacks", "types of attacks", "examples of cyberattacks" },
                ("Common cyberattacks:\n- Phishing\n- Ransomware\n- Malware\n- DDoS attacks",
                new List<string> {
                    "Phishing: fake emails designed to steal sensitive information.",
                    "Ransomware: software that locks files and demands payment for release.",
                    "DDoS: Distributed Denial of Service, an attack that floods servers with traffic to crash them." }, ConsoleColor.Magenta) },

            { new List<string> { "phishing" },
                ("Phishing tricks users into giving info through fake emails or links.",
                new List<string> {
                    "Check the sender's email address carefully.",
                    "Do not click on unknown or suspicious links.",
                    "Look for HTTPS in the URL to verify it's a secure site." }, ConsoleColor.Green) },

            { new List<string> { "ransomware" },
                ("Ransomware locks your files and demands payment. Backup your data regularly.",
                new List<string> {
                    "Backup data regularly to avoid losing important files.",
                    "Use antivirus software to detect ransomware threats.",
                    "Never pay the ransom, as it may encourage further attacks." }, ConsoleColor.Red) },

            { new List<string> { "malware" },
                ("Malware is malicious software designed to harm or exploit devices, networks, or users.",
                new List<string> {
                    "Install antivirus software to detect and remove malware.",
                    "Avoid downloading unknown files or software from untrusted sources.",
                    "Keep your operating system and applications updated to patch security holes." }, ConsoleColor.DarkRed) },

            { new List<string> { "protect", "hackers", "secure my computer" },
                ("Protect your computer:\n- Install antivirus\n- Update software\n- Use strong passwords\n- VPN and firewalls",
                new List<string> {
                    "Use a VPN to protect your privacy when browsing online.",
                    "Update your operating system to prevent vulnerabilities.",
                    "Antivirus software helps prevent and remove threats." }, ConsoleColor.Yellow) },

            { new List<string> { "firewall" },
                ("A firewall filters network traffic and blocks unauthorized access.",
                new List<string> {
                    "Block unwanted traffic that could be malicious.",
                    "Update firewall settings regularly to enhance security.",
                    "Consider using hardware firewalls for better protection." }, ConsoleColor.Blue) },

            { new List<string> { "vpn" },
                ("A VPN hides your IP address and encrypts your internet traffic for privacy.",
                new List<string> {
                    "Use a VPN when connected to public Wi-Fi networks.",
                    "Choose a trusted VPN provider that doesn't log your activity.",
                    "A VPN encrypts your traffic, making it harder for hackers to intercept." }, ConsoleColor.Gray) },
        };

        public string GenerateAnswer(string userQuestion, string userName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userQuestion))
                    return "Please ask a cybersecurity-related question.";

                userQuestion = userQuestion.Trim().ToLower();

                ConsoleColor[] questionColors = { ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Cyan, ConsoleColor.Green, ConsoleColor.Yellow };
                Random rand = new Random();
                ConsoleColor randomColor = questionColors[rand.Next(questionColors.Length)];

                Console.ForegroundColor = randomColor;
                Console.WriteLine($"You asked: {userQuestion}");
                Console.ResetColor();

                foreach (var entry in responses)
                {
                    foreach (var keyword in entry.Key)
                    {
                        if (userQuestion.Contains(keyword))
                        {
                            var mainResponse = entry.Value.Item1;
                            var subInfo = entry.Value.Item2;
                            var answerColor = entry.Value.Item3;

                            string response = $"Great question, {userName}! Here's some info:\n\n{mainResponse}\n\nMore tips:\n";

                            foreach (var bullet in subInfo)
                                response += $"- {bullet}\n";

                            Console.ForegroundColor = answerColor;
                            Console.WriteLine(response);
                            Console.ResetColor();

                            return "";
                        }
                    }
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hmm, I don't have an answer for that yet. Ask about cybersecurity topics!");
                Console.ResetColor();
                return "";
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
                return "";
            }
        }
    }
}
