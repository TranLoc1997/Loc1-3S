using System.Collections.Generic;
using TaskUser.Models.Production;

namespace TaskUser.ViewsModels.BrandViewsModels
{
    public class BrandViewsModels
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        
        public virtual ICollection<Product>Product { get; set; }
    }
}