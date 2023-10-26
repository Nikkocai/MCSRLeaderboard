using SpeedrunComSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCSRLeaderboard
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            var client = new SpeedrunComClient();

            var game = client.Games.SearchGame(name: "Minecraft: Java Edition");

            MessageBox.Show("Las categorías de Minecraft que vicio me das son:");

            foreach (var category in game.Categories)
            {
                MessageBox.Show(category.Name);
            }

        }
    }
}
