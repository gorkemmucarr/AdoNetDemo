﻿using Northwind.Enitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> getProductsByProductName(string searchKey);
        void Update(Product product);
    }
}
