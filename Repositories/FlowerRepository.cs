using BOs;
using DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class FlowerRepository : IFlowerRepository
    {
        private readonly FlowerDAO _flowerDAO;

        public FlowerRepository(FlowerDAO flowerDAO)
        {
            _flowerDAO = flowerDAO;
        }

        public List<Flower> GetFlowers(string searchString, string order, string sortBy, int pageNumber, int pageSize, string categoryIds)
        {
            return _flowerDAO.GetFlowers(searchString, order, sortBy, pageNumber, pageSize, categoryIds);
        }
    }
}
