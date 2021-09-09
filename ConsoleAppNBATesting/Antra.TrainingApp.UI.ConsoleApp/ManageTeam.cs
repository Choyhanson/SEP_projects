using System;
using System.Collections.Generic;
using System.Text;
using Antra.NBATestingApp.Data.Model;
using Antra.NBATestingApp.Data.Repository;

namespace Antra.TrainingApp.UI.ConsoleApp
{
    class ManageTeam
    {
        IRepository<Team> teamRepository;

        public ManageTeam()
        {
            teamRepository = new TeamRepository();
        }
        void AddTeam()
        {
            Team T = new Team();
            Console.Write("Enter the Team Name: ");
            T.TeamName = Console.ReadLine();
            if (teamRepository.Insert(T)>0)
            {
                Console.WriteLine("Team Added successfully");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        void UpdateTeam()
        {
            Team T = new Team();
            Console.Write("Enter the Team ID: ");
            T.TeamId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the New Team Name: ");
            T.TeamName = Console.ReadLine();
            if (teamRepository.Update(T) > 0)
            {
                Console.WriteLine("Team Updated successfully");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }
        void DeleteTeam()
        {
            Console.Write("Enter the Team ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (teamRepository.Delete(id) > 0)
            {
                Console.WriteLine("Team has been Deleted successfully");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        void PrintAll()
        {
            IEnumerable<Team> teamCollection = teamRepository.GetAll();
            if (teamCollection!=null)
            {
                foreach (var item in teamCollection )
                {
                    Console.WriteLine(item.TeamId+"\t"+item.TeamName);
                }
            }
        }
        
        
        void PrintById()
        {
            Console.Write("Enter the Team Id you want to display: ");
            int id = Convert.ToInt32(Console.ReadLine());
            List<Team> teamCollection = teamRepository.GetById(id);
            if (teamCollection!=null)
            {
                foreach (var item in teamCollection)
                {
                    Console.WriteLine(item.TeamId+"\t"+item.TeamName);
                }
            }
        }
        public void Run()
        {
            PrintAll();
        }

    }
}
