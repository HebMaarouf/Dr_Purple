using Dr_Purple.Application.Utility.Paging;
using Dr_Purple.Application.Utility.Results;
using MediatR;

namespace Dr_Purple.Application.Services.BlogServices.Queries;

public record GetAllTagQuery(QueryOptions Options) : IRequest<IResult>;