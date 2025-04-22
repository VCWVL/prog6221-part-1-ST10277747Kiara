using System.Media;

namespace ST10277747_Prog_POEPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Play sound
            SoundPlayer sp = new SoundPlayer("ElevenLabs_Text_to_Speech_audio.wav");
            sp.Play();

            string catName = "Mittens";

            // ASCII cat
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
          .'\   /`.
         .'.-.`-'.-.`.
    ..._:   .-. .-.   :_...
  .'    '-.(o ) (o ).-'    `.
 :  _    _ _`~(_)~`_ _    _  :
:  /:   ' .-=_   _=-. `   ;\  :
:   :|-.._  '     `  _..-|:   :
 :   `:| |`:-:-.-:-:'| |:'   :
  `.   `.| | | | | | |.'   .'
    `.   `-:_| | |_:-'   .'
     `-._   ````    _.-'
          ``-------''
");
            Console.ResetColor();

            Console.WriteLine("\nWelcome to the Cybersecurity Chatbot! 🛡️");

            var chatbotInterface = new ChatbotInterface();

            // Get valid name
            while (true)
            {
                Console.Write("Please enter your name: ");
                string inputName = Console.ReadLine();

                try
                {
                    chatbotInterface.Name = inputName;
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.ResetColor();
                }
            }

            Console.WriteLine($"Hi {chatbotInterface.Name}! {catName} is curled up beside me ready to help too. 🐱");
            Console.WriteLine("Ask me anything about cybersecurity (type 'exit' to quit).");

            while (true)
            {
                Console.Write("\nYou: ");
                string userQuestion = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userQuestion))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\nChatbot: Hmm... {catName} and I didn't catch that. Please ask again!");
                    Console.ResetColor();
                    continue;
                }

                if (userQuestion.ToLower() == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nChatbot: Goodbye, {chatbotInterface.Name}! {catName} says 'Meow!' Stay safe! 👋🐾");
                    Console.ResetColor();
                    break;
                }

                
            }
        }
    }
}
