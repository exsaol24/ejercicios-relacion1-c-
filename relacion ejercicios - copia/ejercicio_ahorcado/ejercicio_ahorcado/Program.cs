using System.Text;


namespace ahorcadoAlvaro
{
    class Program
    {
        static char currentLetter;
        enum State { PLAYING, WIN, LOSE }
        static State state = State.PLAYING;
        const int FAILURES = 8;

        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Trabajo creado por Alvaro Perez Sanchez");

            string[] words = { "minecraft", "monster hunter", "naruto",
            "papelera", "loco suave", "aprobado", "jose", "desdentado" };
            Random generator = new Random();
            int randomNumber = generator.Next(0, words.Length);
            string wordGuess = words[randomNumber];
            int failures = FAILURES;

            string WordShow = "";
            for (int i = 0; i < wordGuess.Length; i++)
                if (wordGuess[i] == ' ')
                    WordShow += " ";
                else
                    WordShow += "-";


            

            string word = "";


            do
            {
                Console.Clear();

                Console.WriteLine("La palabra a adivinar:  " + WordShow);

                Console.WriteLine("Intentos restantes: " + failures);
                Hanged(failures);
                word += currentLetter;


                char[] wordnum = new char[word.Length];
                for (int i = 0; i < wordnum.Length; i++)
                {
                    wordnum[i] = word[i];
                }


                Order(wordnum);

                Console.Write("Introduzca una letra: ");

                try
                {
                    currentLetter = Char.ToLower(Convert.ToChar(Console.ReadLine()));


                    if (currentLetter == ' ' || currentLetter == 'ñ')
                    {
                        throw new Exception();
                    }
                    else
                    {
                        if (!wordGuess.Contains(currentLetter))
                        {

                            throw new Exception();

                        }
                        else
                        {
                            if (word.Contains(currentLetter))
                            {
                                throw new Exception();
                            }
                            else
                            {
                                // letras += currentLetter;


                            }
                        }

                    }

                }
                catch (Exception)
                {
                    failures--;
                }

                string nextShow = "";

                for (int i = 0; i < wordGuess.Length; i++)
                {
                    if (currentLetter == wordGuess[i])
                        nextShow += currentLetter;
                    else
                        nextShow += WordShow[i];
                }
                WordShow = nextShow;


                if (!WordShow.Contains("-"))
                {
                    Console.Clear();
                    Console.WriteLine("Felicidades, acertaste!  ({0})",
                        wordGuess);
                    state = State.WIN;
                    Console.WriteLine("░░░░░░░▄██▄░░░░░░▄▄░░");
                    Console.WriteLine("░░░░░░░▐███▀░░░░░▄███▌");
                    Console.WriteLine("░░▄▀░░▄█▀▀░░░░░░░░▀██░");
                    Console.WriteLine("░█░░░██░░░░░░░░░░░░░░░");
                    Console.WriteLine("█▌░░▐██░░▄██▌░░▄▄▄░░░▄");
                    Console.WriteLine("██░░▐██▄░▀█▀░░░▀██░░▐▌");
                    Console.WriteLine("██▄░▐███▄▄░░▄▄▄░▀▀░▄██");
                    Console.WriteLine("▐███▄██████▄░▀░▄█████▌");
                    Console.WriteLine("▐████████████▀▀██████░");
                    Console.WriteLine("░▐████▀██████░░█████░░");
                    Console.WriteLine("░░░▀▀▀░░█████▌░████▀░░");
                    Console.WriteLine("░░░░░░░░░▀▀███░▀▀▀░░░░");
                }
                else if (failures == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Lo siento. Era " + wordGuess);
                    state = State.LOSE;
                    Console.WriteLine("────(♥)(♥)(♥)───(♥)(♥)(♥)──── Si estas en soledad,");
                    Console.WriteLine("──(♥)██████(♥)─(♥)██████(♥)── seré tu sombra.");
                    Console.WriteLine("─(♥)█████████(♥)█████████(♥)─ si quieres llorar,");
                    Console.WriteLine("─(♥)█████████████████████(♥)─ tendrás mi hombro.");
                    Console.WriteLine("──(♥)███████████████████(♥)── si necesitas un abrazo,");
                    Console.WriteLine("────(♥)███████████████(♥)──── seré tu almohada.");
                    Console.WriteLine("──────(♥)███████████(♥)────── si ansias estar feliz,");
                    Console.WriteLine("────────(♥)███████(♥)──────── estaré sonriente.");
                    Console.WriteLine("──────────(♥)███(♥)────────── y cada vez que me necesites,");
                    Console.WriteLine("─────────────(♥)───────────── aquí estaré presente.");
                }

                Console.WriteLine();

            }
            while (state == State.PLAYING);
        }

        static void Hanged(int failures)
        {
            switch (failures)
            {
                case 8:

                    Console.WriteLine("-");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 7:

                    Console.WriteLine("-------");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 6:

                    Console.WriteLine("-------");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 5:

                    Console.WriteLine("-------");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|    O");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 4:

                    Console.WriteLine("-------");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|    O");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 3:

                    Console.WriteLine("-------");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|    O");
                    Console.WriteLine("|   /|");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 2:

                    Console.WriteLine("-------");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|    O");
                    Console.WriteLine("|   /|\\");
                    Console.WriteLine("|");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 1:

                    Console.WriteLine("-------");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|    O");
                    Console.WriteLine("|   /|\\");
                    Console.WriteLine("|   /  ");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;
                case 0:

                    Console.WriteLine("-------");
                    Console.WriteLine("|    |");
                    Console.WriteLine("|    O");
                    Console.WriteLine("|   /|\\");
                    Console.WriteLine("|   / \\");
                    Console.WriteLine("|");
                    Console.WriteLine("----");
                    break;


            }
        }
        static void Order(char[] word)
        {
            string ultimate = "";


            for (int i = 0; i < word.Length - 1; i++)
            {
                for (int j = i + 1; j < word.Length; j++)
                {
                    if (word[i] > word[j])
                    {
                        char aux = word[i];

                        word[i] = word[j];
                        word[j] = aux;
                    }
                }
            }
            for (int i = 1; i < word.Length; i++)
            {
                if (i == 1)
                {
                    ultimate += word[i];
                }
                else
                {
                    ultimate += $", {word[i]}";
                }
            }
            Console.WriteLine($"la Letras usada: [{ultimate}]");
        }

    }

}



