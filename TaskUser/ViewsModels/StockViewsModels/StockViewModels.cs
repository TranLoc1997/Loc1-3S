﻿using TaskUser.Models.Production;
using TaskUser.Models.Sales;

namespace TaskUser.ViewsModels.StockViewsModels
{
    public class StockViewModels
    {
        public int Quantity { get; set; }
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        
        public virtual Store Store { get; set; }
        public virtual Product Product { get; set; }
    }
}