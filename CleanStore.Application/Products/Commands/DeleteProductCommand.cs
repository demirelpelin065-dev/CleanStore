using MediatR;

namespace CleanStore.Application.Products.Commands;

public record DeleteProductCommand(int Id) : IRequest<bool>;
