using CleanStore.Domain.Entities;
using CleanStore.Domain.Interfaces;
using MediatR;

namespace CleanStore.Application.Products.Queries;

public class GetAllProductsQueryHandler
    : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
{
    private readonly IRepository<Product> _repository;

    public GetAllProductsQueryHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Product>> Handle(
        GetAllProductsQuery request,
        CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}
