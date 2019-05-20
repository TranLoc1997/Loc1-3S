using System.Collections.Generic;
using TaskUser.Models.Production;
using TaskUser.Models.Sales;

namespace TaskUser.ViewsModels.StoreViewsModels
{
    public class StoreViewModels
    {
        public int Id { get; set; }
        public string StoreName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public virtual ICollection<User> users { get; set; }
        
        public virtual ICollection<Stock>Stocks { get; set; }
    }
}