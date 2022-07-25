using Shopping.DTOs;
using Shopping.Entities.Domain;
using Shopping.Entities.Interfaces;
using Shopping.UseCasesPorts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.UseCases.CreateProduct
{
    public class CreateProductInteractor : ICreateProductInputPort
    {
        readonly IProductRepository Repository;
        readonly IUnitOfWork UnitOfWork;
        readonly ICreateProductOutputPort OutputPort;
        public CreateProductInteractor(IProductRepository repository, IUnitOfWork unitOfWork, ICreateProductOutputPort outputPort)
        {
            Repository = repository;
            UnitOfWork = unitOfWork;
            OutputPort = outputPort;
        }

        public async Task Handle(CreateProductDTO product)
        {
            var newProduct = new Product()
            {
                Name = product.ProductName
            };
            Repository.CreateProduct(newProduct);
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle(
                new ProductDTO
                {
                    Id = newProduct.Id,
                    Name = newProduct.Name
                }
            );
        }
    }
}
