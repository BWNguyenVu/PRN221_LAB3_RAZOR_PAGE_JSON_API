using BOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IFlowerService
    {
        List<Flower> GetFlowers(string searchString, string order, string sortBy, int pageNumber, int pageSize, string categoryIds);
    }
}
