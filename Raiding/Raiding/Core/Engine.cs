using System;
using System.Collections.Generic;
using System.Text;

using Raiding.Models;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private const string INVALID_HERO = "Invalid hero!";

        public Engine()
        {

        }
        public void Run()
        {
            List<BaseHero> allHero = new List<BaseHero>();
            BaseHero hero = null;

            int lines = int.Parse(Console.ReadLine());
            int allDmg = 0;
            int counter = 0;

            while (lines != counter)
            {
                string name = Console.ReadLine();
                string heroClass = Console.ReadLine();
                try
                {
                    switch (heroClass)
                    {
                        case "Druid":
                            hero = new Druid(name);
                            break;

                        case "Paladin":
                            hero = new Paladin(name);
                            break;

                        case "Rogue":
                            hero = new Rogue(name);
                            break;

                        case "Warrior":
                            hero = new Warrior(name);
                            break;

                        default:
                            throw new InvalidOperationException(INVALID_HERO);

                    }

                    counter++;
                    allDmg += hero.Power;
                    allHero.Add(hero);

                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            foreach (var heros in allHero)
            {
                Console.WriteLine(heros.CastAbility());
            }

            string result = EndGame(allDmg);
            Console.WriteLine(result);


        }

        private string EndGame(int allDmg)
        {
            int bossDmg = int.Parse(Console.ReadLine());

            if (allDmg >= bossDmg)
            {
                return "Victory!";
            }
            return "Defeat...";
        }
    }
}
