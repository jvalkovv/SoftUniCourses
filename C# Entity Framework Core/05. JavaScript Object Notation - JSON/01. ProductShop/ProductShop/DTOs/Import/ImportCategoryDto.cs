using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProductShop.DTOs.Import
{
    public class ImportCategoryDto
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
