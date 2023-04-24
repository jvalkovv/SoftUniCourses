using System.ComponentModel.DataAnnotations.Schema;

namespace ProductShop.Models
{
    using System.Collections.Generic;

    public class User
    {
        public User()
        {
            this.ProductsSold = new List<Product>();
            this.ProductsBought = new List<Product>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public int? Age { get; set; }

        [InverseProperty(nameof(Product.Seller))]
        public virtual ICollection<Product> ProductsSold { get; set; } = null!;

        [InverseProperty(nameof(Product.Buyer))]
        public virtual ICollection<Product> ProductsBought { get; set; } = null!;
    }
}