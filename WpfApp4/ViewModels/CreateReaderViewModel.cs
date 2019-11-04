using WpfApp4.Core.Command;
using WpfApp4.Core.Data.Repository;
using WpfApp4.Core.Validation;
using WpfApp4.Models;

namespace WpfApp4.ViewModels
{
    public class CreateReaderViewModel : BaseViewModel
    {
        private IReaderRepository ReaderRepository { get; }

        private RelayCommand createReaderCommand;

        private RelayCommand updateReaderCommand;

        private ReaderValidator ReaderValidator { get; }

        public CreateReaderViewModel(IReaderRepository readerRepository)
        {
            ReaderRepository = readerRepository;
            EditableReader = new Reader();
            ReaderValidator = new ReaderValidator(EditableReader);
        }

        public CreateReaderViewModel(IReaderRepository readerRepository, Reader readerToEdit)
        {
            ReaderRepository = readerRepository;
            EditableReader = readerToEdit;
            ReaderValidator = new ReaderValidator(EditableReader);
        }

        public Reader EditableReader { get; set; }

        public RelayCommand CreateReaderCommand => createReaderCommand ??
                (createReaderCommand = new RelayCommand(obj =>
                {
                    ReaderRepository.Create(EditableReader);
                },
                obj => ReaderValidator.Validate()));

        public RelayCommand UpdateReaderCommand => updateReaderCommand ??
                (updateReaderCommand = new RelayCommand(obj =>
                {
                    ReaderRepository.Update(EditableReader);
                },
                obj => ReaderValidator.Validate()));
    }
}
