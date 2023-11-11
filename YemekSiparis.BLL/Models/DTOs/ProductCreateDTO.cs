using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YemekSiparis.Core.Entities;

namespace YemekSiparis.BLL.Models.DTOs
{
    public class ProductCreateDTO
    {

        public string Name { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte? Image { get; set; }
        public int PrepTime { get; set; }
        public decimal Discount { get; set; }
        public int CategoryID { get; set; }
        public List<DietListDTO> Diets { get; set; }
    }
}
