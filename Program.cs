
namespace StopWatch
{

    public class StopWatch
    {
        static void Main(string[] args)
        {

            MainMenu();

        }

        static void InterfaceConsole()
        {

            string line = "";

            for (int x = 0; x <= 30; x++)
            {

                Console.Write($"{line + "="}");

            }

            Console.WriteLine("");

        }

        static void MainMenu()
        {

            InterfaceConsole();

            Console.WriteLine("Qual você deseja realizar (timer) ou (stopwatch)");
            Console.WriteLine("-> Sair (sair)");
            string inputFunction = Console.ReadLine() ?? "".ToLower();

            if (inputFunction == "timer")
                MenuTimer();

            if (inputFunction == "stopwatch")
                MenuStopWatch();

            if (inputFunction == "sair")
            {

                int oneSec = 1000;
                string line = "";

                Console.Clear();

                for (int x = 0; x <= 5; x++)
                {
                    Console.Write(line + ".");
                    Thread.Sleep(oneSec);
                }

                System.Environment.Exit(0);

            }


            if (inputFunction != "timer" && inputFunction != "stopwatch")
                Console.WriteLine("Esse comando não existe");


        }

        static void MenuStopWatch()
        {

            InterfaceConsole();

            Console.WriteLine("S: Segundos (ex) => 1s = 1 segundo");
            Console.WriteLine("M: Minutos (ex) => 1m = 1 minuto");
            Console.WriteLine("Exit: Sair");

            string inputData = Console.ReadLine() ?? "".ToLower();

            if (inputData == "sair")
                System.Environment.Exit(0);

            char type = char.Parse(inputData.Substring(inputData.Length - 1, 1));
            int time = int.Parse(inputData.Substring(0, inputData.Length - 1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;


            if (time == 0)
                System.Environment.Exit(0);


            StartStopWatch(time * multiplier);

        }
        static void MenuTimer()
        {

            InterfaceConsole();

            Console.WriteLine("S: Segundos (ex) => 1s = 1 segundo");
            Console.WriteLine("M: Minutos (ex) => 1m = 1 minuto");
            Console.WriteLine("Exit: Sair");

            string inputData = Console.ReadLine() ?? "".ToLower();

            if (inputData == "sair")
                System.Environment.Exit(0);


            char type = char.Parse(inputData.Substring(inputData.Length - 1, 1));
            int time = int.Parse(inputData.Substring(0, inputData.Length - 1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;


            if (time == 0)
                System.Environment.Exit(0);


            StartTimer(time * multiplier);

        }

        static void StartStopWatch(int time)
        {

            int currentTime;

            // Um segundo em milisegundos
            int oneSec = 1000;

            for (currentTime = 1; currentTime != time; currentTime++)
            {
                Console.Clear();
                Console.WriteLine(currentTime);

                // Metodo que espera um segundos
                Thread.Sleep(oneSec);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado");
            Thread.Sleep(oneSec);

            InterfaceConsole();

            MainMenu();
        }

        static void StartTimer(int time)
        {
            int currentTime;

            // Um segundo em milisegundos
            int oneSec = 1000;

            for (currentTime = time; currentTime >= 0; currentTime--)
            {
                Console.Clear();
                Console.WriteLine(currentTime);

                // Metodo que espera um segundos
                Thread.Sleep(oneSec);
            }

            Console.Clear();
            Console.WriteLine("Timer finalizado");
            Thread.Sleep(oneSec);

            InterfaceConsole();

            MainMenu();
        }
    }
}