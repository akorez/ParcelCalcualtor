using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetcadCodeAssignment.Abstract
{
    public interface IParcelProcess
    {
        Dictionary<int, int> CalculateNeededParcels(List<int> boxes);

    }
}
