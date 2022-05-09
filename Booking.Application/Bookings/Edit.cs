using AutoMapper;
using Core;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Bookings
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Booking Booking { get; set; } = default!;
        }


        public class Handler : IRequestHandler<Command>
        {
            private readonly IMapper _mapper;
            private readonly DataContext _context;
            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var booking = await _context.Bookings.FindAsync(request.Booking.Id);
                if (booking == null)
                    return Unit.Value;

                _mapper.Map(request.Booking, booking);

                await _context.SaveChangesAsync(); 

                return Unit.Value;
            }
        }

    }
}
