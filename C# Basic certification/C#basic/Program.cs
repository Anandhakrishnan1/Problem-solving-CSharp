using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{

    public class Team
    {
        public string teamName { get; set; }
        public int noOfPlayers { get; set; }

        public Team(string name, int number)
        {
            teamName = name;
            noOfPlayers = number;
        }

        public void AddPlayer(int count)
        {
            noOfPlayers = noOfPlayers + count;
        }

        public bool RemovePlayer(int count)
        {
            if ((noOfPlayers - count) < 0)
            {
                return false;
            }
            noOfPlayers = noOfPlayers - count;
            return true;
        }

        public virtual void ChangeTeamName(string str)
        {
            teamName = str;
        }
    }

    public class Subteam : Team
    {
        public Subteam(string name, int number) : base(name, number) { }

        public override void ChangeTeamName(string str)
        {
            base.ChangeTeamName(str);
        }
    }
    class Solution
    {
        static void Main(string[] args)
        {

            if (!typeof(Subteam).IsSubclassOf(typeof(Team)))
            {
                throw new Exception("Subteam class should inherit from Team class");
            }

            String str = Console.ReadLine();
            String[] strArr = str.Split();
            string initialName = strArr[0];
            int count = Convert.ToInt32(strArr[1]);
            Subteam teamObj = new Subteam(initialName, count);
            Console.WriteLine("Team " + teamObj.teamName + " created");

            str = Console.ReadLine();
            count = Convert.ToInt32(str);
            Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            teamObj.AddPlayer(count);
            Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);


            str = Console.ReadLine();
            count = Convert.ToInt32(str);
            Console.WriteLine("Current number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            var res = teamObj.RemovePlayer(count);
            if (res)
            {
                Console.WriteLine("New number of players in team " + teamObj.teamName + " is " + teamObj.noOfPlayers);
            }
            else
            {
                Console.WriteLine("Number of players in team " + teamObj.teamName + " remains same");
            }

            str = Console.ReadLine();
            teamObj.ChangeTeamName(str);
            Console.WriteLine("Team name of team " + initialName + " changed to " + teamObj.teamName);
        }
    }
}