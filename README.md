/*
Cybersecurity Awareness Chatbot – "Mittens the Cat"
---------------------------------------------------

The Cybersecurity Awareness Chatbot is a Windows Console Application developed using C#. 
This program aims to educate users about cybersecurity by allowing them to interact with a friendly chatbot assistant named Mittens the Cat. 
The chatbot makes learning about cybersecurity both engaging and informative by offering detailed responses to a variety of user questions. 
The entire project was developed by Kiara Israel, student number ST10277747, for the PROG6221 module.

To run this project successfully, users need to have Visual Studio or Visual Studio Code installed on their machine. 
It is also essential to have the .NET 6.0 SDK or later installed. Once the environment is ready, 
the user can clone the project repository from GitHub using 'git clone [your-repo-link]'. 
After cloning, they should open the project folder or solution file in Visual Studio or Visual Studio Code. 
Building the project can be done by clicking "Run" in Visual Studio, or by using the command 'dotnet run' in the terminal within VS Code.

When the application starts, it immediately creates a welcoming atmosphere by playing an audio clip using the SoundPlayer class from the System.Media namespace. 
Simultaneously, a colorful ASCII art image of Mittens the Cat is displayed on the console in cyan color, 
giving the chatbot a fun and friendly introduction. After this, the user is prompted to enter their name. 
The system includes strong validation techniques: the name must not be empty and must consist of alphabetical letters only. 
Any input errors are clearly communicated through red-colored console messages, ensuring that the user understands exactly what went wrong without causing any crashes.

Once a valid name is entered, Mittens personally greets the user and invites them to ask any cybersecurity-related questions. 
The chatbot interface then takes over, handling all interactions. Users can type their questions naturally — whether they ask "What is cybersecurity?" 
or "Explain phishing" — and Mittens will search an internal dictionary for relevant keywords. 
Matching a keyword results in the chatbot providing a detailed and user-friendly response about that specific cybersecurity topic. 
Topics such as phishing, ransomware, malware, and general cybersecurity advice are handled with care and provide extra tips on how users can stay safe online. 
If a keyword is not recognized, the chatbot responds politely, encouraging the user to try asking another way, without crashing or becoming unresponsive.

Each user's message and each chatbot response is displayed in random console colors, making the conversation lively and engaging. 
This simple but effective visual touch keeps the user entertained during longer conversations. 
Additionally, solid error handling practices have been put in place to ensure that unexpected inputs do not break the program. 
Instead, friendly and professional error messages maintain the application’s flow and user experience.

The entire chat continues until the user types "exit". When that happens, the chatbot personally says goodbye, thanking the user by name, 
and Mittens gives a final meow to wrap up the session. The application then safely closes, ensuring that the entire interaction feels complete and satisfying.

The structure of the project is well-organized into several classes. The Program.cs file acts as the controller of the overall application. 
It handles the sequence of events from startup to shutdown, including playing the sound, displaying the cat art, welcoming the user, and managing the conversation loop. 
The CybersecurityQuestion.cs class is a simple but important model that defines what a cybersecurity question and its corresponding answer look like, 
providing a clean structure for any expansions in the future.

The ChatbotInterface.cs class is responsible for managing user interaction. It validates user names and ensures the program only accepts clean, professional input. 
It also acts as a bridge between the user and the chatbot engine, making sure every question asked is passed correctly for processing. 
Finally, the Chatbot.cs class is where the real intelligence of Mittens lives. This class stores a dictionary of cybersecurity topics and their associated answers. 
It is also responsible for identifying keywords in the user's input, generating appropriate responses, and randomly changing the console colors to keep the interaction visually dynamic.

Overall, this project showcases a solid understanding of object-oriented programming principles. 
It demonstrates how to structure a project cleanly using multiple classes, how to perform input validation effectively, 
how to handle errors gracefully, and how to enhance a console application's user experience using colors and sounds. 
The chatbot not only teaches users about cybersecurity but also ensures that learning happens in an enjoyable and interactive manner.

By following these steps and understanding how each part of the codebase works together, anyone can run and enjoy this application on their own machine. 
Thank you for exploring the Cybersecurity Awareness Chatbot with Mittens the Cat. Stay safe online!
*/
