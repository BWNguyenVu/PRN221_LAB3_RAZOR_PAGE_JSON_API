using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BOs
{
    public class Flower
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public string Address { get; set; }
        public List<Category> Categories { get; set; }
        public List<Image> Images { get; set; }
        public string Status { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime FlowerExpireDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Views { get; set; }
        public bool IsDeleted { get; set; }
    }
}
