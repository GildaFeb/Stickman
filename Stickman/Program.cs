using System;

namespace Stickman
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===========================================================");
            Console.WriteLine("                       WELCOME                                 ");



            for (; ; )
            {
                try
                {

                    Console.WriteLine("===========================================================");
                    Console.WriteLine("               CHOOSE YOUR FIGHTER:");
                    Console.WriteLine("1. Emman");
                    Console.WriteLine("2. Slippy");
                    Console.WriteLine("3. Totoy");
                    Console.Write("4. Exit \n> ");
                    String name = Console.ReadLine(); ;
                    switch (name)
                    {

                        case "1":
                            Console.WriteLine("\a \t       ╔══════╗ ");
                            Console.Write("\a \t      <* ô  ô *>\n  ");
                            Console.Write("\a \t" + "       ║  |   ║       \n");
                            Console.Write("\a \t" + "       ║  ▬▬  ║    \t He is Emman. \n");
                            Console.Write("\a \t" + "       ╚══════╝  √ \t He always helps his friends. \n");
                            Console.Write("\a \t" + "          ║     *\t He gives his code without payment. \n ");
                            Console.Write("\a \t" + "          ║*  *  \t He is generous. \n     ");
                            Console.Write("\a \t" + "        * ║ * \n  ");
                            Console.Write("\a \t" + "       *  ║\t       BE EMMAN. \n ");
                            Console.Write("\a \t" + "      *   ║\n");
                            Console.Write("\a \t" + "         * * " + "\n");
                            Console.Write("\a \t" + "        *   *" + "\n");
                            Console.Write("\a \t" + "       ║     ║" + "\n");
                            Console.Write("\a \t" + "       ║     ║" + "\n");
                            Console.Write("\a \t" + "      ═╝     ╚═" + "\n");
                            Console.Write("\a \t" + "                         " + "\n");
                            break;

                        case "2":

                            Console.WriteLine("\a \t        ");
                            Console.Write("\a \t    ≤( Ü , Ü )≥\n  ");
                            Console.Write("\a \t" + "         v\n");
                            Console.Write("\a \t" + "         U\n");
                            Console.Write("\a \t" + "         ║\n    ");
                            Console.Write("\a \t" + "       ╔═║═╗\t She Tria. \n     ");
                            Console.Write("\a \t" + "       ║ ║ ╚══*\t She is not stressed in java.        \t\n   ");
                            Console.Write("\a \t" + "       * ║    \n  ");
                            Console.Write("\a \t" + "         ║\t  BE TRIA. \n   ");
                            Console.Write("\a \t" + "        *  *" + "\n");
                            Console.Write("\a \t" + "        *   *  " + "\n");
                            Console.Write("\a \t" + "         *    *  " + "\n");
                            Console.Write("\a \t" + "           *   *   " + "\n");


                            break;
                        case "3":
                            Console.WriteLine("\a \t                       He is Totoy.  ");
                            Console.WriteLine("\a \t                       He codes very well.");
                            Console.WriteLine("\a \t            ╤  ");
                            Console.WriteLine("\a \t         ╔═════╗       HOPE ALL.");
                            Console.WriteLine("\a \t         ╚═════╝                       ╔══════════════╗");
                            Console.WriteLine("\a \t         ( Ó,Ó )                       ║              ║");
                            Console.WriteLine("\a \t           » «                         ║              ║");
                            Console.WriteLine(@"                   /║\       ║                 ╚══════════════╝");
                            Console.WriteLine(@"                  / ║ \      ║               ╚╔══════════╗╝ ");
                            Console.WriteLine(@"                 o  ║  o     ║          ╔══════════════════════════╗");
                            Console.WriteLine(@"                    ║        ╔════╗     ║                          ║ ");
                            Console.WriteLine(@"                   / \       ║    ║     ║                          ║ ");
                            Console.WriteLine(@"                  ║   ║      ║    ║     ╚══════════════════════════╝");
                            Console.WriteLine(@"                 ═╝   ╚═                                          ");
                            Console.WriteLine(@"                         ");


                            break;
                        case "4":
                            Console.WriteLine("===========================================================");

                            System.Environment.Exit(1);
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("===========================================================");
                    Console.WriteLine("                   TRY AGAIN.                       ");
                }
            }

            {

            }
        }
    }
}
