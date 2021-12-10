using System;

namespace Spelletje_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Main variabelen
            string titel = "Galgje";
            string opgegevenWoord = "paard";
            string geradenLetter = string.Empty;
            string geradenWoord = string.Empty;
            int beurt = 7;
            string eindresultaat = string.Empty;
            //programma

            //MaakTitelAan(titel, opgegevenWoord);

            do
            {
                geradenLetter = GebruikerGoktEenLetter();
                geradenWoord = VergelijkLetterMetWoord(geradenLetter, opgegevenWoord);

                Console.WriteLine(geradenWoord);
                beurt--;

            } while (beurt > 0);




            Console.ReadLine();
            WinOrLose(opgegevenWoord, geradenWoord, beurt);
            string keuze = Console.ReadLine();
            if (keuze == "Y")
            {

            }

        }

        private static void WinOrLose(string opgegevenWoord, string geradenWoord, int beurt)
        {
            if ((geradenWoord == opgegevenWoord) || (beurt == 0))
            {
                GameOverSchermWin();
            }
            else
            {
                GameOverSchermLose();
            }
        }

        /*public static string MaakGok()

        {
            bool isLetter = false;
            bool isLeeg = false;
            bool isEenKarakter = false;
            bool voorwaarde = false;
            string resultaat = string.Empty;

            string gok = string.Empty;
            do
            {
                Console.Write("Raad een letter: ");
                resultaat = Console.ReadLine();
                isLeeg = string.IsNullOrEmpty(gok);
                isLetter = !int.TryParse(gok, out int getalGok);
                isEenKarakter = gok.Length == 1;
                voorwaarde = !isLeeg && isEenKarakter && isLetter;
            } while (!voorwaarde);
            return resultaat;
        }*/
        private static string GebruikerGoktEenLetter()

        {
            bool isLetter = false;
            bool isLeeg = false;
            bool isEenKarakter = false;
            bool voorwaarde = false;


            string gok = string.Empty;
            do
            {
                Console.Write("Raad een letter: ");
                gok = Console.ReadLine().ToLower();
                isLeeg = string.IsNullOrEmpty(gok);
                isLetter = !int.TryParse(gok, out int getalGok);
                isEenKarakter = gok.Length == 1;
                voorwaarde = !isLeeg && isEenKarakter && isLetter;
            } while (!voorwaarde);
            return gok;

        }

        private static string VergelijkLetterMetWoord(string geradenLetter, string opgegevenWoord)
        {
            string resultaat = string.Empty;
            string huidigResultaat = geradenLetter;
            string vorigResultaat = string.Empty;
            string basisWoord = opgegevenWoord;
            string woordMetSter = string.Empty;
            string nieuwWoordMetSter = string.Empty;
            string symbool = "*";

            for (int i = 0; i < basisWoord.Length; i++)
            {
                if (huidigResultaat == basisWoord[i].ToString())
                {

                    resultaat += huidigResultaat;

                }
                else if (huidigResultaat != basisWoord[i].ToString())
                {

                    resultaat += symbool;
                }

            }
            woordMetSter = resultaat;
            for (int i = 0; i < woordMetSter.Length; i++)
            {
                bool isKarakter = false;
                if (isKarakter)
                {
                    nieuwWoordMetSter = woordMetSter.Replace(symbool, huidigResultaat);
                    woordMetSter = nieuwWoordMetSter;
                }


            }
            return woordMetSter;
        }

            

        /*private static void PasGokresultaatAan(string oplossing, string gok)
        {
            string resultaat = string.Empty;
            string tussenResultaat = string.Empty;
            for (int i = 0; i < oplossing.Length; i++)
            {
                if (gok == oplossing[i].ToString())
                {
                    tussenResultaat += gok;
                }
                else
                {
                    tussenResultaat += "*";
                }
                return (gok, oplossing);
            }

            tussenResultaat = Combineerresultaat(resultaat, oplossing, tussenResultaat);*/
    }


}

