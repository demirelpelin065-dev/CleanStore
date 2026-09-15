using CleanStore.Domain.Entities;
using CleanStore.Domain.Interfaces;
using MediatR;

namespace CleanStore.Application.Products.Commands;

public class UpdateProductCommandHandler
    : IRequestHandler<UpdateProductCommand, Product?>
{
    private readonly IRepository<Product> _repository;

    public UpdateProductCommandHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<Product?> Handle(
        UpdateProductCommand request,
        CancellationToken cancellationToken)
    {
        var product = await _repository.GetByIdAsync(request.Id);

        if (product is null)
        {
            return null;
        }

        product.Name = request.Name;
        product.Price = request.Price;
        product.CategoryId = request.CategoryId;

        _repository.Update(product);
        await _repository.SaveChangesAsync();

        return product;
    }
}
