using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public  class Collectiom
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Salary { set; get; }

         static void Main(string[]args)
         {
            /* Employee p1 = new Employee { empId = 01 };
             ArrayList list = new ArrayList();
             list.Add(p1);

             list.Add(10);
           //  list.Add("Hello");
           //  list.Add(63.78);

             list.Insert(0, 5);
             list.Insert(2, 50);

             int[] arr = new int[] { 100, 55, 200 };
             list.AddRange(arr);

            // list.Remove(63.78);

             string name=list[3].ToString();
             double d = Convert.ToDouble(list[4]);

             foreach (var item in list)
             {
                 Console.WriteLine(item);
             }

             list.Sort();
             list.Reverse();

             foreach (var item in list)
             {
                 Console.WriteLine(item);
             }*/


         }
    }
    public class Service
    {
        
        public int Id { get; set; }
        public string Name { set; get; }
        public int Price { set; get; }

        public (string name, int runs)
        {
            this.name = name;
            this.runs = runs;
        }

    }
    public class CollArrayLis
    {
        static void Main(string[] args)
        {
            Service s = new Service { Id = 01, Name = "Keyboard", Price = 4500 };
            Collectiom c = new Collectiom { Id = 02, Name = "Mouse", Salary=2000 };

            ArrayList list = new ArrayList();
            list.Add(s);
            list.Add(c);

            foreach( var item in list)
            {
                if(typeof(Service)==item.GetType())
                {
                    Service ss = (Service)item;
                    Console.WriteLine(ss.Id + " " + ss.Name + " " + ss.Price);
                }
                else if (typeof(Collectiom)==item.GetType())
                {
                    Collectiom cc=(Collectiom)item;
                    Console.WriteLine(cc.Id + " " + cc.Name + " " + cc.Salary);
                }
            }
        }
    }
    public class Player : IComparable
    {
        private string name;
        private int runs;
        public Player(string name, int runs)
        {
            this.name = name;
            this.runs = runs;
        }

        public int CompareTo(object obj)// obj=player4
        {

            Player p4 = (Player)obj;  // type casting
            // to access runs of palyer1 we use this
            // this--> point to the current object
            if (this.runs > p4.runs)
            {
                return 1;
            }
            else if (this.runs < p4.runs)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{name} -> {runs}";
        }
    }
    public class Team : IEnumerable
    {
        private Player[] players;
        public Team()
        {
            players = new Player[5];
            players[0] = new Player("Rohit", 45);
            players[1] = new Player("Virat", 80);
            players[2] = new Player("Ishan", 79);
            players[3] = new Player("Ashwin", 33);
            players[4] = new Player("Hardik", 88);
        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            Team team = new Team();
            foreach (Player p in team)
            {
                Console.WriteLine(p);
            }

            Player players1 = new Player("Rohit", 53);
            Player players2 = new Player("Virat", 80);
            Player players3 = new Player("Ishan", 79);
            Player players4 = new Player("Ashwin", 53);
            Player players5 = new Player("Hardik", 88);

            int result = players1.CompareTo(players4);
            if (result == 1)
            {
                Console.WriteLine("rohit has more runs than ashwin");
            }
            else if (result == -1)
            {
                Console.WriteLine("rohit has less runs than ashwin");
            }
            else
            {
                Console.WriteLine("rohit & ashwin has same score");
            }
        }

    }




}
