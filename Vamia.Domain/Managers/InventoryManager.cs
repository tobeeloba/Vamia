﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vamia.Models;
using Vamia.Data.Repositories;
using Vamia.Data;

namespace Vamia.Domain.Managers
{
    public class InventoryManager
    {
        private InventoryRepository _inventory;

        public InventoryManager()
        {
            DataContext context = new DataContext();
            _inventory = new InventoryRepository(context);

        }
        public InventoryManager(InventoryRepository inventory)
        {
            _inventory = inventory;
        }

        public List<ProductModel> GetProducts()
        {
            var products = _inventory.GetProducts();
            return products.ToList();
        }
    }
}
