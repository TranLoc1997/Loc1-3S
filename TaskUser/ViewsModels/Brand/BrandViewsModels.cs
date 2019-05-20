using System.Collections.Generic;
using TaskUser.Models.Production;

namespace TaskUser.ViewsModels.Brand
{
    public class BrandViewsModels
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        
        public virtual ICollection<Models.Production.Product>Product { get; set; }
    }
}