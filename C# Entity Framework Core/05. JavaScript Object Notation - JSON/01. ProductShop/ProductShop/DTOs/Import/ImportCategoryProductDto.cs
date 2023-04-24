using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProductShop.DTOs.Import
{
    public class ImportCategoryProductDto
    {
        [JsonProperty("CategoryId")]
        public int CategoryId { get; set; }


        [JsonProperty("ProductId")]
        public int ProductId { get; set; }
    }
}
