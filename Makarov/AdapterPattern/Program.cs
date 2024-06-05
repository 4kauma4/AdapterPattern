using System;
using ComputerGameLibray;
using AdapterLibrary;

namespace AdapterPattern
{

    class Program
    {
        public static void Main()
        {
            ComputerGame game = new ComputerGame(
                "Смута",
                PegiAgeRating.P18,
                60,
                8192,
                70,
                16,
                8,
                3.5
            );

            PCGame pcGame = new ComputerGameAdapter(game);

            Console.WriteLine("Title: " + pcGame.GetTitle());
            Console.WriteLine("PEGI Allowed Age: " + pcGame.GetPegiAllowedAge());
            Console.WriteLine("Is AAA Game: " + pcGame.IsTripleAGame());
            Requirements requirements = pcGame.GetRequirements();
            Console.WriteLine("Requirements: ");
            Console.WriteLine("GPU (GB): " + requirements.GetGpuGb());
            Console.WriteLine("HDD (GB): " + requirements.GetHddGb());
            Console.WriteLine("RAM (GB): " + requirements.GetRamGb());
            Console.WriteLine("CPU (GHz): " + requirements.GetCpuGhz());
            Console.WriteLine("Cores: " + requirements.GetCoresNum());
        }
    }
}



