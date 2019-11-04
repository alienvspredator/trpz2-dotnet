using WpfApp4.Models;

namespace WpfApp4.Core.Validation
{
    public class ReaderValidator : PersonValidator<Reader>
    {
        public ReaderValidator(Reader reader) : base(reader)
        {
        }
    }
}
