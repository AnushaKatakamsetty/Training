using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClass
{
    abstract class Player
    {
        protected string name;
        protected string teamname;
        protected int noOfMatches;
        public Player(string name,string teamname,int noOfMatches)
        {
            this.name = name;
            this.teamname = teamname;
            this.noOfMatches = noOfMatches;
        }
        public abstract void DisplayPlayerStatistics();
    }
    class CricketPlayer:Player
    {
        int totalRunsScored;
        int noOfWicketsTaken;
        public CricketPlayer(string name, string teamname, int noOfMatches,int totalRunsScored,int noOfWicketsTaken ):base(name,teamname,noOfMatches)
        {
            this.totalRunsScored = totalRunsScored;
            this.noOfWicketsTaken = noOfWicketsTaken;
        }
        public override void DisplayPlayerStatistics()
        {
            //throw new NotImplementedException();

        }
    }
    class HockeyPlayer:Player
    {
        string position;
        int noOfGoals;
        public HockeyPlayer(string position,int noOfGoals)
        {
            this.position = position;
            this.noOfGoals = noOfGoals;
        }
        public override void DisplayPlayerStatistics()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu\n 1. Cricketplayer details\n 2. )

        }
    }
}
