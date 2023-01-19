namespace LINQ;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Program
    {
        static void Main(string[] args)
        {
        var videoGameList = new List<string>() { "MegaMan", "Call Of Duty", "Contra", "Tetris", "MineCraft", "Street Fighter" };

        var orderedList = videoGameList.OrderBy(x => x.Length).ToList();
        foreach(var item in orderedList)
        {
            Console.WriteLine(item);
        }


        }
    }

