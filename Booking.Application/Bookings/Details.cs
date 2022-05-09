using System;
using MediatR;
using Core;
using Persistence;

namespace Application.Bookings
{
    public class Details
    {
        public class Query: IRequest<Booking>
        {
            public Guid Id { get; set; }
        }

        public class Handler: IRequestHandler<Query, Booking>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Booking> Handle(Query request, CancellationToken  cancellationToken)
            {
                return await _context.Bookings.FindAsync(request.Id);
            }
        }
    }
}
