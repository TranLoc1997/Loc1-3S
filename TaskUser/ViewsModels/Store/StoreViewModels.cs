using System.Collections.Generic;
using TaskUser.Models.Sales;

namespace TaskUser.ViewsModels.Store
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
        public virtual ICollection<Models.Sales.User> users { get; set; }
        
        public virtual ICollection<Models.Production.Stock>Stocks { get; set; }
    }
}