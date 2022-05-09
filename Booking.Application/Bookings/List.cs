using Core;
using MediatR;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Bookings
{
    public class List
    {
        public class Query : IRequest<List<Booking>>
        {

        }

        public class Handler : IRequestHandler<Query, List<Booking>>
        {
            private readonly DataContext _context;

            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Booking>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Bookings.ToListAsync();
            }
        }
    }
}