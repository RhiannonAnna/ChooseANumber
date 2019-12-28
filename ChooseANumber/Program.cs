using System;

namespace ChooseANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string liczbaUzytkownika = ""; //deklaruję zmienną typu string o nazwie liczbaUzytkownika i przypisuję do niego pustego stringa
            bool czyJeszczeZadajemyPytanie = true; //deklaruje zmienną typu bool i przypisuje do niego wartosc true
            int iloscProb = 0; //deklaruje zmienną typu int i przypisuje się do niego wartość 0

            Random random = new Random(); //Tworzę nowy obiekt typu Random (o nazwie zmiennej random)
            int randomNumber = random.Next(1, 10); //deklaruję zmienną typu int i przy wykorzystaniu obiektu Random przypisuję losową liczbe od 1 do 10 

            while (czyJeszczeZadajemyPytanie) //Sprawdzam warunek czyJeszczeZadajemyPytanie, jeśeli ma wartość true wykonuję pętlę
            {
                Console.WriteLine("Wpisz cyfrę od 1 do 10 "); //drukuję w konsoli zdanie informacyjne
                liczbaUzytkownika = Console.ReadLine(); //Przypisuję do zmiennej liczbaUzytkownika wartość podaną przez użytkownika
                iloscProb++; //Inkrementuję zmienną iloscProb

                if (Int32.Parse(liczbaUzytkownika) == randomNumber) //Sprawdzam warunek czy rzutowana na int zmienna liczbaUzytkownika jest równa zmiennej randomNumber i jeżeli tak to wykonuję zawarość body
                {
                    Console.WriteLine("Super! Udało Ci się! Ilość prób to: " + iloscProb); //drukuję w konsoli zdanie informacyjne
                    czyJeszczeZadajemyPytanie = false; //Przypisuję do zmiennej czyJeszczeZadajemyPytanie wartość false, aby zakończyć działanie pętli
                }
                else if (Int32.Parse(liczbaUzytkownika) > randomNumber) //sprawdzam warunek czy zrzutowana liczbaUzytkownika na int jest większa od zmiennej randomNumber  i jeżeli tak to wykonuję zawarość body
                {
                    Console.WriteLine("Niestety! Podana przez Ciebie liczba jest większa"); //Drukuję w konsoli zdanie informacyjne
                }
                else if (Int32.Parse(liczbaUzytkownika) < randomNumber) //Sprawdzam warunek czy zrzutowana liczbaUzytkownika na int jest mniejsza od zmiennej randomNumber  i jeżeli tak to wykonuję zawarość body
                {
                    Console.WriteLine("Niestety! Podana przez Ciebie liczba jest mniejsza"); //Drukuję w konsoli zdanie informacyjne
                }

            }

        }
    }
}
