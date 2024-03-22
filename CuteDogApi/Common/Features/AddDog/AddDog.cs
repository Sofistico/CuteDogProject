using CuteDogApi.Common.Infrastructure.Persistance;
using CuteDogApi.Common.Models;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CuteDogApi.Common.Features.AddDog
{
    public class AddDogController : ControllerBaseDog
    {
        [HttpPost("dog/add")]
        public async Task<ActionResult<Guid>> AddDog([FromBody] AddDogCommand dog)
        {
            return await Bus.Send(dog);
        }
    }

    public class AddDogCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
    }

    public class AddDogCommandValidation : AbstractValidator<AddDogCommand>
    {
        public AddDogCommandValidation()
        {
            RuleFor(d => d.Name).NotNull().NotEmpty();
            RuleFor(d => d.Breed).NotEmpty();
            RuleFor(d => d.Age).InclusiveBetween(0, 30);
        }
    }

    public class AddDogCommandHandler : IRequestHandler<AddDogCommand, Guid>
    {
        private readonly ApplicationDbContext _context;

        public AddDogCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Guid> Handle(AddDogCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
