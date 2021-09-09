using System;

namespace Antra.TrainingApp.UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ManageTeam manageTeam = new ManageTeam();
            ManagePlayer managePlayer = new ManagePlayer();
            managePlayer.Run();
        }
    }
}
