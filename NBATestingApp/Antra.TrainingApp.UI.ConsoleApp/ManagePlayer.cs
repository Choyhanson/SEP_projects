using System;
using System.Collections.Generic;
using System.Text;
using Antra.NBATestingApp.Data.Model;
using Antra.NBATestingApp.Data.Repository;
namespace Antra.TrainingApp.UI.ConsoleApp
{
    class ManagePlayer
    {
        IRepository<Player> playerRepository;
        public ManagePlayer()
        {
            playerRepository = new PlayerRepository();
        }
        void PrintAll()
        {
            IEnumerable<Player> playerCollection = playerRepository.GetAll();
            if (playerCollection!=null)
            {
                foreach (var item in playerCollection)
                {
                    Console.WriteLine(item.PlayerId+"\t"+item.PlayerName+"\t"+
                        item.Teams.TeamId+"\t"+item.Teams.TeamName);
                }
            }
        }

        void DeletePlayer()
        {
            Console.Write("Enter the PlayerId you want to DELETE: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (playerRepository.Delete(id) > 0)
            {
                Console.WriteLine("Player has been Deleted successfully");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        void AddPlayer()
        {
            Player T = new Player();
            Console.Write("Enter the Player Name: ");
            T.PlayerName = Console.ReadLine();
            Console.Write("Enter the PlayerId: ");
            T.PlayerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the TeamID: ");
            Team t = new Team();
            T.Teams = t;
            T.Teams.TeamId = Convert.ToInt32(Console.ReadLine());

            if (playerRepository.Insert(T) > 0)
            {
                Console.WriteLine("Player Added successfully");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
        void UpdatePlayer()
        {
            Player T = new Player();
            Console.Write("Enter the Player Name: ");
            T.PlayerName = Console.ReadLine();
            Console.Write("Enter the PlayerId: ");
            T.PlayerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the TeamID: ");
            Team t = new Team();
            T.Teams = t;
            T.Teams.TeamId = Convert.ToInt32(Console.ReadLine());
            if (playerRepository.Update(T) > 0)
            {
                Console.WriteLine("Player Updated successfully");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
        public void Run()
        {
            AddPlayer();
        }
    }
}
