using CleanStore.Domain.Entities;
using MediatR;

namespace CleanStore.Application.Products.Commands;

public record UpdateProductCommand(
    int Id,
    string Name,
    decimal Price,
    int CategoryId
) : IRequest<Product?>;
