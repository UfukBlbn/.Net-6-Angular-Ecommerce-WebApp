using ECommerceAPI.Application.Abstractions;
using ECommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Concrete
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts()
            => new() 
            { 
                new() {Id = Guid.NewGuid() ,CreatedDate = DateTime.Now, Name = "PR1", Price = 120, Stock = 10 },
                new() {Id = Guid.NewGuid() ,CreatedDate = DateTime.Now, Name = "PR1", Price = 150, Stock = 14 },
                new() {Id = Guid.NewGuid() ,CreatedDate = DateTime.Now, Name = "PR2", Price = 150, Stock = 13 },
                new() {Id = Guid.NewGuid() ,CreatedDate = DateTime.Now, Name = "PR3", Price = 140, Stock = 12 },
                new() {Id = Guid.NewGuid() ,CreatedDate = DateTime.Now, Name = "PR4", Price = 130, Stock = 11 }
             };
    }
}
