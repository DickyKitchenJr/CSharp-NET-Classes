using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_NET_Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, my name is {1}.", to, Name);
        }

        public static Person Parse(string str)
        {
            var anotherPerson = new Person();
            anotherPerson.Name = str;
            return anotherPerson;
        }
    }

    public class Interaction
    {
        public void Fight(List<string> combatants) 
        {
            foreach (var combatant in combatants)
            {
                var attacker = combatants.IndexOf(combatant);
                var defender = (attacker == combatants.Count - 1) ? 0 : attacker + 1;
                if (attacker != (combatants.Count - 1))
                {
                    Console.WriteLine($"{combatants[attacker]} is fighting {combatants[defender]}!");
                }
                else 
                {
                    Console.WriteLine("The fights have ended");
                }
                
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var thisPerson = Person.Parse("Wade");
            thisPerson.Introduce("Logan");

            var fighters = new List<string> { "Wade", "Logan" };
            var fightOne = new Interaction();
            fightOne.Fight(fighters);
        }
    }
}
