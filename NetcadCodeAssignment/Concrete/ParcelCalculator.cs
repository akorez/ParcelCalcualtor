using NetcadCodeAssignment.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetcadCodeAssignment.Concrete
{
    public class ParcelCalculator : IParcelProcess
    {
        public Dictionary<int, int> CalculateNeededParcels(List<int> boxes)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            result.Add(0, boxes.Count * boxes.Max());

            for (int i = 1; i < boxes.Count; i++)
            {
                result.Add(i, SumOfArea(i, boxes));
            }

            return result;
        }

        static int SumOfArea(int i, List<int> boxes)
        {
            var result1 = boxes.GetRange(0, i).Count * boxes.GetRange(0, i).Max();

            var result2 = boxes.GetRange(i, boxes.Count - i).Count * boxes.GetRange(i, boxes.Count - i).Max();

            return result1 + result2;
        }
    }
}
