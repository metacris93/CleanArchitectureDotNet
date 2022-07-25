using Shopping.DTOs;
using Shopping.Entities.Interfaces;
using Shopping.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.UseCases.CreateProduct.GetAllProducts
{
    public class GetAllProductsInteractor : IGetAllProductsInputPort
    {
        readonly IProductRepository Repository;
        readonly IGetAllProductsOutputPort OutputPort;

        public GetAllProductsInteractor(IProductRepository repository, IGetAllProductsOutputPort outputPort)
        {
            Repository = repository;
            OutputPort = outputPort;
        }

        public Task Handle()
        {
            var products = Repository.GetAllProducts().Select(p =>
            new ProductDTO 
            {
                Id = p.Id,
                Name = p.Name,
            });
            OutputPort.Handle(products);
            return Task.CompletedTask;
        }
    }
}
