﻿using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        //isimlendirme olarak sonuna async gelmeliydi
        Task<List<Product>> GetProductsWithCategory();
    }
}
