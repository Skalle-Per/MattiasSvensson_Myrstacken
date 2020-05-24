using System;
using System.Collections.Generic;


namespace Myrstacken_Real_Deal
{
    class Program
    {
        string namn;//globala variabler
        int ben;

        static void Main()
        {
            Program p = new Program();
            p.Run();
        }

        void Run()
        {

            string[] kommandon = new string[7]; //[0] = Hjälp, [1] = Skapa myra, [2] = Myr lista, [3] = Antal myror, [4] = Sök, [5]= Radera myra, [6] = Exit
            Console.WriteLine("Hej, välkommen till Myrstacken");
            Console.Write("Om du inte vet vart du ska börja skriv \"Hjälp\": "); //få användaren att kunna skriva "HJÄLP" och ge info
            kommandon[0] = CommandList(Console.ReadLine());

            while (true)
            {
                kommandon[1] = null;
                Console.Write("\nVad vill du göra: ");
                kommandon[1] = Console.ReadLine();

                if (kommandon[1] == "Skapa myra") //öppnar myr-skaparen KLAR
                {
                    Skapa();
                }
                else if (kommandon[1] == "Myr lista") //visar myr listan
                {
                    kommandon[2] = "Myr lista";
                    kommandon[1] = "Skapa myra";
                    MyrLista();
                }
                else if (kommandon[1] == "Antal myror") //visar antal myror KLAR
                {
                    kommandon[3] = "Antal myror";
                    kommandon[1] = "Skapa myra";
                    Antal();

                }
                else if (kommandon[1] == "Sök myra") //söker efter myror KLAR
                {
                    kommandon[4] = "Sök myra";
                    kommandon[1] = "Skapa myra";

                    Sök();
                }
                else if (kommandon[1] == "Radera myra") //raderar myror KLAR
                {
                    kommandon[5] = "Radera myra";
                    kommandon[1] = "Skapa myra";
                    Radera();
                }
                else if (kommandon[1] == "Exit") //stänger ner programmet KLAR
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Ogiltigt kommand.....");
                }
            }

        }
        private List<Myra> myrLista = new List<Myra>();

            static string CommandList(string hjälp) //metoden för kommando listan
            {
                
                string resultat = hjälp;
                if (hjälp == "Hjälp")               
                    {
                        
                        Console.WriteLine("\n\"Skapa myra\": Tar dig till skapelse sektionen"); 
                        Console.WriteLine("\n\"Myr lista\": Visar listan av de skapade myrorna med deras namn samt antalet ben");
                        Console.WriteLine("\n\"Antal myror\": Visar antalet myror skapade i nummer"); 
                        Console.WriteLine("\n\"Sök myra\": Söker efter myror");
                        Console.WriteLine("\n\"Radera\" + \"Myrans namn\": Raderar bort den specificerade myran");
                    Console.WriteLine("\n\"Exit\": Stänger ner programmet");
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt Command!");
                        Console.Write("Skriv Hjälp: ");
                        string hjälp2 = CommandList(Console.ReadLine());
                    }               
                return resultat;
            }


            private void Skapa()
            {
                Console.WriteLine("Öppnar Myr skaparen....:");
                Console.Write("Skriv myrans namn: ");
                namn = Console.ReadLine().ToLower();
                Console.Write("Skriv antalet ben: ");
                ben = Convert.ToInt32(Console.ReadLine());
            Myra myra = new Myra(namn, ben);
            myrLista.Add(myra);
            Console.WriteLine("Myran har skapats!");

            }

        private void Radera()
        {
                Console.Write("Skriv myrans namn: ");
                string namn = Console.ReadLine();
                foreach (Myra p in myrLista)
                {
                    if (p.GetNamn() == namn)
                    {
                        myrLista.Remove(p);
                        Console.WriteLine("Myran har raderats :(");
                        return;

                    }
                }
            
        }

        private void MyrLista()
        { 

            for (int i = 0; i < myrLista.Count; i++)
            {
                Console.Write(myrLista[i].GetNamn() );
                Console.Write(" " + myrLista[i].GetBen() + "\n");
            }
        }

        private void Antal()
        {
            Console.WriteLine(Myra.antal);
        }

        private void Sök()
        {
            Console.WriteLine("Skriv \"Namn\" för att söka efter specifika myror, skriv \"Ben\" för att söka efter myror med ett visst antal ben: ");
            string sök = Console.ReadLine();
            if (sök == "Namn")
                
            {
                Console.Write("Skriv myrans namn: ");
                string sökNamn = Console.ReadLine().ToLower();
                
                for (int i = 0; i < myrLista.Count; i++)
                {
                    if (myrLista[i].GetNamn() == sökNamn.ToLower())
                    {
                        Console.WriteLine(sökNamn + " finns!");
                    }
                    else
                    {
                        Console.WriteLine(sökNamn + " finns inte....");
                    }
                }
            }
            else if (sök == "Ben")
            {
                Console.Write("Skriv antalet ben du vill söka: ");
                int sökBen = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < myrLista.Count; i++)
                {                   
                        if (myrLista[i].GetBen() == sökBen)
                        {
                            Console.WriteLine(myrLista[i].GetBen());
                        Console.WriteLine("Det finns så många med det antalet ben!");
                        }
                        else
                        {
                            Console.WriteLine("Det finns inga myror med" + sökBen + "st ben....");
                        }   
                    
                }
            }

           

        }


        
    }

 }
