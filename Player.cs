using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityBot
{
    internal class Player
    {
        public void Play(string path)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(path);
                player.Play(); 
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error playing sound: " + ex.Message);
                Console.ResetColor();
            }
        }
    }
}
 