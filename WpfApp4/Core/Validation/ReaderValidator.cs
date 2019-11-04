using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Models;

namespace WpfApp4.Core.Validation
{
    class ReaderValidator : PersonValidator<Reader>
    {
        public ReaderValidator(Reader reader) : base(reader)
        {
        }
    }
}
