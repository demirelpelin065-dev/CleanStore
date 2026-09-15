using CleanStore.Domain.Entities;
using MediatR;

namespace CleanStore.Application.Products.Queries;

public record GetAllProductsQuery : IRequest<IEnumerable<Product>>;
