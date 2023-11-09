using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSiparis.BLL.Models.DTOs
{
    public class ProductUpdateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? Rating { get; set; }
        public int ClickCount { get; set; } = 0;
        public byte? Image { get; set; }
        public int PrepTime { get; set; }
        public decimal Discount { get; set; } = 0;
        public int CategoryID { get; set; }
        public List<DietListDTO> Diets { get; set; }
    }
}
