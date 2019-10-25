using WpfApp4.Core.Command;
using WpfApp4.Core.Data.Repository;
using WpfApp4.Models;
using WpfApp4.Core.Validation;

namespace WpfApp4.ViewModels
{
    public class ReaderDetailsViewModel : BaseViewModel
    {
        public ReaderDetailsViewModel(Reader reader)
        {
            Reader = reader;
            Fullname = $"{Reader.Name} {Reader.Surname}";
        }

        public Reader Reader { get; }

        public string Fullname { get; }
    }
}
