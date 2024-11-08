using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AppointmentValidator : AbstractValidator<Appointment>
    {
        //validation kuralları ctora yazılır
        public AppointmentValidator()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            RuleFor(a => a.AvailableDate).NotEmpty();
            RuleFor(a => a.Status).NotEmpty();
            RuleFor(a => a.LastUpdateDate).LessThanOrEqualTo(DateTime.Now);
            RuleFor(a => a.AvailableDate).GreaterThanOrEqualTo(today).When(a => a.VisaCategoryId == 1).WithMessage("Turistik vizenin tarihi gelecek olmalı.");
        }
    }
}
