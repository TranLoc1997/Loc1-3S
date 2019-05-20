using System.Collections.Generic;
using TaskUser.Models.Production;

namespace TaskUser.ViewsModels.CategoryViewsModels
{
    public class CategoryViewsModels
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        
        public virtual ICollection<Product>Products { get; set; }

    }
}