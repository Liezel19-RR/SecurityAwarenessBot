using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace CyberSecurityBot
{
    internal class Program
    {
        // INTERFACE (Abstraction)
        interface IChat
        {
            void GetUserName();
            void StartChat();
        }

        
        class User : Person
        {
        }

        
        
       
        class ChatBot : User, IChat
        {
            TypingEffect typer = new TypingEffect();

            public void GetUserName()
            {
                while (string.IsNullOrWhiteSpace(Name))
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Enter your name: ");
                        Console.ResetColor();
                        

                        Name = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(Name))
                            throw new Exception("Name cannot be empty!");
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ex.Message);
                        Console.ResetColor();
                    }
                }
            }

            public void StartChat()
            {
                typer.Type($"\nHello {Name}! I am your Cyber Security Assistant 🤖");

                bool running = true;

                while (running)
                {
                    ShowMenu();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Enter choice: ");
                    Console.ResetColor();

                    string input = Console.ReadLine().ToLower();

                    switch (input)
                    {
                        case "1":
                        case "how are you":
                            typer.Type("I'm functioning perfectly 😊");
                            break;

                        case "2":
                        case "purpose":
                            typer.Type("My purpose is to teach cyber security awareness.");
                            break;

                        case "3":
                        case "topics":
                            typer.Type("You can ask about Passwords, Phishing, Safe Browsing.");
                            break;

                        case "4":
                        case "password":
                            typer.Type("Use long passwords with symbols, numbers and never share them.");
                            break;

                        case "5":
                        case "phishing":
                            typer.Type("Never click suspicious emails or unknown links.");
                            break;

                        case "6":
                        case "browsing":
                            typer.Type("Always check HTTPS before entering personal info.");
                            break;

                        case "7":
                        case "exit":
                            typer.Type("Goodbye 👋 Stay safe online!");
                            running = false;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid option.");
                            Console.ResetColor();
                            break;
                    }
                }
            }

            private void ShowMenu()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n╔════════ MENU ════════╗");
                Console.WriteLine("Choose from Menu:");
                Console.WriteLine("1. How are you");
                Console.WriteLine("2. Purpose");
                Console.WriteLine("3. Topics");
                Console.WriteLine("4. Password Safety");
                Console.WriteLine("5. Phishing");
                Console.WriteLine("6. Safe Browsing");
                Console.WriteLine("7. Exit");
                Console.WriteLine("╚══════════════════════╝");
                Console.ResetColor();
            }
        }
        static void Main(string[] args)
        {
          
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
   ____      _                  ____                 
  / ___| ___| |_ ___  _ __ ___ / ___|  ___ __ _ _ __ 
 | |  _ / _ \ __/ _ \| '__/ _ \ |  _ / __/ _` | '__|
 | |_| |  __/ || (_) | | |  __/ |_| | (_| (_| | |   
  \____|\___|\__\___/|_|  \___|\____|\___\__,_|_|   
");
            
            Console.ResetColor();

            Player music = new Player();
            music.Play(@"C:\Users\Student\source\repos\CyberSecurityBot\WhatsApp Ptt 2026-04-13 at 15.22.04.wav");


            try
            {
                ChatBot bot = new ChatBot();
                bot.GetUserName();
                Console.Clear();
                bot.StartChat();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unexpected error: " + ex.Message);
                Console.ResetColor();
            }
        }
    }
    
}
