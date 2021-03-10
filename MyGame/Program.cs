using System;
using NeonShooter;
namespace MyGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new NeonShooterGame())
                game.Run();
        }
    }
}
