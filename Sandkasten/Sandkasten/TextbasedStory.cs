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

                // Zeig das Rechnenweg mit eingegbenes X an
                Console.WriteLine($"{y} + {x} = {z}");

                string boosterUnlock = (inputBooster == z) ? "whoosh, You sucessfully escaped the Pirates :D" : "Boooommmm, Oh no... We were hit in the engine, looks like our adventure is over.";

                Console.WriteLine(boosterUnlock);


                Console.WriteLine("To be continued");
                break;

            }

        }
    }
}
