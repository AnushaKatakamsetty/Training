using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeQst
{
    class Trainee
    {
       public  int traineeId,projectId;
       public  string traineeName;
        public Trainee(int traineeId,string traineeName,int projectId)
        {
            this.traineeId = traineeId;
            this.traineeName = traineeName;
            this.projectId = projectId;
        }
        public override string ToString()
        {
            return this.traineeName;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size:");
            int size = int.Parse(Console.ReadLine());
            List<Trainee> ls = new List<Trainee>();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter trId:");
                int traineeId = int.Parse(Console.ReadLine());
                Console.WriteLine("enter trName:");
                string trName = Console.ReadLine();
                Console.WriteLine("enter projectId:");
                int prId = int.Parse(Console.ReadLine());
               // List<Trainee> ls = new List<Trainee>();
                // List<int> 
               
                ls.Add(new Trainee(traineeId, trName, prId));
            }
            List<Trainee> lst = ls.FindAll(t => t.projectId != -1);
            foreach(Trainee t in lst)
            {
                Console.WriteLine(t.ToString());
            }

        }
    }
}
