using CleanStore.Domain.Entities;
using MediatR;

namespace CleanStore.Application.Products.Queries;

public record GetProductByIdQuery(int Id) : IRequest<Product?>;
