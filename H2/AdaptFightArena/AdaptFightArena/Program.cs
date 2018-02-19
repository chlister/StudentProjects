using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptFightArena
{
    class Program
    {
        static int round = 0;
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    // lavede det her så alle får lov at prøve ellers ender den i nullref hele tiden
                    switch (round)
                    {
                        case 1:
                            IFighter fighter = Fight(new Fighter(), new Fighter());
                            Console.WriteLine(fighter.ToString() + " eeeer wins!");
                            round++;
                            break;
                        case 2:
                            IFighter fighter2 = Fight(new Fighter(), new WizardAdapter(new Wizard()));
                            Console.WriteLine(fighter2.ToString() + " wins!");
                            round++;
                            break;
                        case 3:
                            IFighter fighter3 = Fight(new Fighter(), new DragonAdapter(new Dragon()));
                            Console.WriteLine(fighter3.ToString() + " wins!");
                            round++;
                            break;
                        default:
                            round = 1;
                            break;
                    }
                }
                catch (NullReferenceException e)
                {
                    //Console.WriteLine(e.StackTrace);
                    //Console.WriteLine(e.Source);
                    round++;
                    Console.WriteLine("Both fighters are dead!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something else happend");
                }
                Console.ReadLine();

            } while (true);
        }
        public static IFighter Fight(IFighter f1, IFighter f2)
        {

            while ((!f1.HasEscaped() && !f2.HasEscaped()) && ((f1.DefenseLeft > 0) && (f2.DefenseLeft > 0)))
            {
                // Første fighter henter attack
                int attack = f1.Attack();
                // Anden fighter skal forsvare sig
                f2.Defend(attack);
                // Anden fighter henter attack
                attack = f2.Attack();
                // Første fighter skal forsvare sig
                f1.Defend(attack);
            }

            IFighter winner = null;

            // kampen er afsluttet
            if ((f1.DefenseLeft > 0) && (!f1.HasEscaped()))

                winner = f1;

            if ((f2.DefenseLeft > 0) && (!f2.HasEscaped()))
                winner = f2;

            // Hvis der returneres null, så har kampen været jævnbyrdig
            return winner;

        }
    }
}
