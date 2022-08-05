using System;
using System.Collections;


namespace CSharpAssignments
{
    class Player
    {
        public string Name { get; set; }
        public int Run { get; set; }
        public Player(string name, int run)
        {
            Name = name;
            Run = run;
        }
    }
    class Team : IEnumerable
    {
        private Player[] playerArray = new Player[4];
        public Team()
        {
            playerArray[0] = new Player("Virat Kohli", 25);
            playerArray[1] = new Player("MS Dhoni", 35);
            playerArray[2] = new Player("KL Rahul", 29);
            playerArray[3] = new Player("MD Shami", 34);
        }
        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("Players in Team: ");
            foreach(Player player in playerArray)
            {
                yield return player;
            }

        }
    }
    public class MyProgram
    {
        public static void Main(string[] args)
        {
            Team India = new Team();

            India.GetEnumerator();
            foreach (Player player in India)
            {
                Console.WriteLine($"Name: {player.Name} Run: {player.Run}");
            }
            Console.ReadLine();
        }
    }
}