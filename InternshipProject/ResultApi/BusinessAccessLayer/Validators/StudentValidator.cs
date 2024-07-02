using FluentValidation;
using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class StudentValidator:AbstractValidator<StudentDTO>
    {
        public StudentValidator()
        {
            RuleFor(s=>s.FirstName).NotNull().NotEmpty();
            RuleFor(s=>s.LastName).NotNull().NotEmpty();
            RuleFor(s=>s.Standard).NotNull().NotEmpty();
            RuleFor(s=>s.Email).NotNull().NotEmpty().EmailAddress();
            RuleFor(s=>s.PhoneNumber).NotNull().NotEmpty();
        }
    }
}
