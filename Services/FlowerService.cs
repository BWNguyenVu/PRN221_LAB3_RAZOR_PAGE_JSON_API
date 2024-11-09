using BOs;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Services
{
    public class FlowerService : IFlowerService
    {
        private readonly IFlowerRepository _flowerRepository;

        public FlowerService(IFlowerRepository flowerRepository)
        {
            _flowerRepository = flowerRepository;
        }

        public List<Flower> GetFlowers(string searchString, string order, string sortBy, int pageNumber, int pageSize, string categoryIds)
        {
            return _flowerRepository.GetFlowers(searchString, order, sortBy, pageNumber, pageSize, categoryIds);
        }
    }
}
