
using Dr_Purple.Application.Utility.Results;
using MediatR;

namespace Dr_Purple.Application.Services.PaymentServices.Queries;

public record GetFirstAppointmentPaymentQuery(Guid Id) : IRequest<IResult>;