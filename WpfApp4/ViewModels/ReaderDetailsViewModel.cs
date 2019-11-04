using WpfApp4.Models;

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
