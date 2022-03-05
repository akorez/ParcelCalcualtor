using NetcadCodeAssignment.Abstract;
using NetcadCodeAssignment.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NetcadCodeAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IParcelProcess parcelCalculator = new ParcelCalculator();
            List<List<int>> boxesList = new List<List<int>>();

            boxesList.Add(new List<int> { 3, 2, 4 });
            boxesList.Add(new List<int> { 5, 3, 2, 4 });
            boxesList.Add(new List<int> { 5, 4, 5, 2, 1 });
            boxesList.Add(new List<int> { 5, 5, 5, 2, 5, 5, 5 });
            boxesList.Add(new List<int> { 1, 1, 6, 5, 5, 5 });


            foreach (var boxes in boxesList)
            {
                Dictionary<int, int> parcelList = new Dictionary<int, int>();

                parcelList = parcelCalculator.CalculateNeededParcels(boxes);                

                // Gereken toplam alan

                var output = parcelList.Min(a => a.Value);

                Console.WriteLine($"TOPLAM ALAN :{output}");

                // İhtiyaç duyulan koli sayısı ve koliye konulacak kutuların çıktısını veren kısım aşağıdadır

                var index = parcelList.Where(a => a.Value == output).First().Key;

                if (index == 0)
                {
                    Console.WriteLine($"TEK KOLİDE : {boxes.Max()} * { boxes.Count}");
                }
                else
                {
                    Console.WriteLine($"İKİ KOLİDE :");

                    Console.WriteLine($"1.KOLİ : {boxes.GetRange(0, index).Max()} * { index}");

                    Console.WriteLine($"2.KOLİ : {boxes.GetRange(index, boxes.Count - index).Max()} * { boxes.Count - index}");
                }

                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
