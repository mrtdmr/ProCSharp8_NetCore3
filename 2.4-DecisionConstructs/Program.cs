using System;

namespace _2._4_DecisionConstructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static string FromRainbowClassic(string colorBand)
        {
            return colorBand switch
            {
                "Red" => "#FF0000",
                "Orange" => "#FF7F00",
                "Yellow" => "#FFFF00",
                "Green" => "#00FF00",
                "Blue" => "#0000FF",
                "Indigo" => "#4B0082",
                "Violet" => "#9400D3",
                _ => "#FFFFFF",
            };
        }
        static string RockPaperScissors(string first, string second)
        {
            return (first, second) switch
            {
                ("rock", "paper") => "Paper wins.",
                ("rock", "scissors") => "Rock wins.",
                ("paper", "rock") => "Paper wins.",
                ("paper", "scissors") => "Scissors wins.",
                ("scissors", "rock") => "Rock wins.",
                ("scissors", "paper") => "Scissors wins.",
                (_, _) => "Tie.",
            };
        }
    }
}
