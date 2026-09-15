using CleanStore.Domain.Entities;
using CleanStore.Domain.Interfaces;
using MediatR;

namespace CleanStore.Application.Products.Commands;

public class CreateProductCommandHandler
    : IRequestHandler<CreateProductCommand, Product>
{
    private readonly IRepository<Product> _repository;

    public CreateProductCommandHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<Product> Handle(
        CreateProductCommand request,
        CancellationToken cancellationToken)
    {
        var product = new Product
        {
            Name = request.Name,
            Price = request.Price,
            CategoryId = request.CategoryId
        };

        await _repository.AddAsync(product);
        await _repository.SaveChangesAsync();

        return product;
    }
}
