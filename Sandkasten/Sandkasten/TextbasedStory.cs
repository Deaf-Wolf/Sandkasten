namespace Sandkasten
{
    class TextbasedStory
    {
        static void Main(string[] args)
        {

            //Änder die Schrift Farbe in Console
            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine("Hello World!");
            Console.WriteLine("Are you Ready? YES/NO");

            // User gibt antwort mit Yes oder No
            string answer = Console.ReadLine();

            //Schreib die Antword automatisch groß, so dass die code nicht auf Rechtschreibung achtet. 
            answer = answer.ToUpper();
            //Zeig die Antwort zum Prüfen an
            Console.WriteLine($"Answer:{answer}");

            if (answer == "YES")
            {
                Console.WriteLine("Get Ready to take off");

                //Countdown (Es Fehlt ein warte code)
                for (int i = 10; i > -1; i--)
                    Console.WriteLine(i);

            }
            else
            {
                // Bei Antwort Nein, wird das Code beendet 
                Console.WriteLine("How Sad :(");
                Console.WriteLine("Looks like our adventure ends here.");
                return;

            }



            //Bei Antwort Yes geht hier weiter 
            Console.WriteLine("You are now in Space");
            Console.WriteLine(" ");
            Console.WriteLine("Oh no The Math Pirates are coming, Find out the X to unlock the escape-booster");

            //Zahl Generator
            var rand = new Random();
            for (int a = 0; a <= 1; a++)
            {
                int x = rand.Next(101);
                int y = rand.Next(101);
                int z = x + y;

                //Zeig das Rechnenweg mit unbekannten X an 
                Console.WriteLine($"{y} + {x} = X");

                Console.Write("X = ");
                int inputBooster = Convert.ToInt32(Console.ReadLine());

                // Zeig das Rechnenweg mit Lösung an
                Console.WriteLine($"{y} + {x} = {z}");


                if (inputBooster == z)
                {
                    Console.WriteLine("whoosh, You sucessfully escaped the Pirates :D");
                }
                else
                {
                    Console.WriteLine("Boooommmm, Oh no... We were hit in the engine, looks like our adventure is over.");
                    return;
                }




                break;

            }
            Console.WriteLine("With the escapeBooster, we landed in a another Solar System ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("But looks like we are at the Switch System, it has 3 planets.");
            Console.WriteLine("");
            Console.WriteLine("Eden Pluto2 Atlantis");
            Console.WriteLine("Tell me which planet you want to know more:");
            //Switch und method/class
            string planet = Console.ReadLine();




            switch (planet)
            {
                case "Eden":
                    Console.WriteLine("Eden, but not Really");
                    break;

                case "Pluto2":
                    Console.WriteLine("It´s a Planet, because its bigger that Pluto");
                    break;

                case "Atlantis":
                    Console.WriteLine("Think of Venecia, but Worldwide!");
                    break;
            }


            Console.WriteLine("To be continued");
        }
    }
}