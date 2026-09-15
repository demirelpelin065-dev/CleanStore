using CleanStore.Domain.Entities;
using CleanStore.Domain.Interfaces;
using MediatR;

namespace CleanStore.Application.Products.Commands;

public class DeleteProductCommandHandler
    : IRequestHandler<DeleteProductCommand, bool>
{
    private readonly IRepository<Product> _repository;

    public DeleteProductCommandHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(
        DeleteProductCommand request,
        CancellationToken cancellationToken)
    {
        var product = await _repository.GetByIdAsync(request.Id);

        if (product is null)
        {
            return false;
        }

        _repository.Delete(product);
        await _repository.SaveChangesAsync();

        return true;
    }
}
