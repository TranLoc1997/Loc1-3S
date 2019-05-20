using System.Collections.Generic;
using TaskUser.Models.Production;

namespace TaskUser.ViewsModels.Category
{
    public class CategoryViewsModels
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        
        public virtual ICollection<Models.Production.Product>Products { get; set; }

    }
}