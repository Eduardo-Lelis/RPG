using System;

namespace RPG.src.Entities
{

    public class RPG
    {

        public static void Main ()
        {

            
                int IntroMenuUser;  //intro 
                int InputHeroTypePlayer;
                int i;
                Console.Write("*********************************");
                    for(i=0;i<=7;i++)
                {
                    Console.WriteLine("*                                *");
                    if(i==4)
                    {
                        Console.Write(string.Format("|<<WELCOME TO FANTASY>>|"));
                    }
                }
                Console.WriteLine("*********************************");
                Console.WriteLine("Please, chose the options bellow: ");  //Menu
                Console.WriteLine("\r\n1-Create a White Wizard\r\n2-Create a Knight\r\n3-Create a Ninja\r\n4-Create a Black Wizard");
                InputHeroTypePlayer=int.Parse(Console.ReadLine());

                    switch (InputHeroTypePlayer)  //estrutura switch para instanciar objeto
                        {
                            case 1: CreateJenica();
                            break;
                            
                            case 2: CreateArus();
                            break;

                            case 3: CreateWedge();
                            break;

                            case 4: CreateTopapa();

                            break;

                            default:

                                Console.WriteLine("This option doesn't exist!");
                            break;

                        }
                           
        }
            private static void CreateJenica()
            {
                Console.WriteLine("Great! Creating Jenica...");
                Wizard Jenica = new Wizard("Jenica", 42, "WhiteWizard");
                Console.WriteLine(Jenica.ToString());
            }

            private static void CreateArus()
            {
                Console.WriteLine("Great! Creating Arus...");
                Knight Arus = new Knight ("Arus",42,"Knight");
                Console.WriteLine(Arus.ToString());
            }

            private static void CreateWedge()
            {
            Console.WriteLine("Great! Creating Ninja...");
            Ninja Wedge = new Ninja ("Wedge",42,"Ninja");
            Console.WriteLine(Wedge.ToString());
            }

            private static void CreateTopapa()
            {
            Console.WriteLine("Great! Creating Black Wizard...");
            BlackWizard Topapa = new BlackWizard ("Topapa",42,"BlackWizard");
            Console.WriteLine(Topapa.ToString());
            }
        

    }
}