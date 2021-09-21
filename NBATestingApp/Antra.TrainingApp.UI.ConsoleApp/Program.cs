using System;
using System.Linq;
namespace Antra.TrainingApp.UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageTeam manageTeam = new ManageTeam();
            manageTeam.Run();
            //ManagePlayer managePlayer = new ManagePlayer();
            //managePlayer.Run();
        }
    }
}
