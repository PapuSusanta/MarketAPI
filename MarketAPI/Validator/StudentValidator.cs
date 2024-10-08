
using MarketAPI.Models.Student;

namespace MarketAPI.Validator;
public class StudentValidator : AbstractValidator<StudentRequest>
{
    public StudentValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Email).EmailAddress();
        RuleFor(x => x.Phone).NotEmpty();

    }
}