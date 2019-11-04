using System.Collections.Generic;
using System.Linq;
using WpfApp4.Core.Command;
using WpfApp4.Core.Data.Repository;
using WpfApp4.Models;

namespace WpfApp4.ViewModels
{
    public class ReadersListViewModel : BaseViewModel
    {
        private List<Reader> readers = new List<Reader>();

        private RelayCommand deleteReaderCommand;

        private RelayCommand updateReadersCommand;

        private Reader selectedReader;

        public ReadersListViewModel(IReaderRepository readerRepository)
        {
            ReaderRepository = readerRepository;
            UpdateList();
        }

        public Reader SelectedReader
        {
            get => selectedReader;
            set
            {
                selectedReader = value;
                RaisePropertyChanged();
            }
        }

        public IReaderRepository ReaderRepository;

        public List<Reader> Readers
        {
            get => readers;
            set
            {
                readers = value;
                RaisePropertyChanged();
            }
        }

        private void UpdateList()
        {
            Readers = ReaderRepository.GetAll().ToList();
        }

        public RelayCommand DeleteReaderCommand => deleteReaderCommand ??
                (deleteReaderCommand = new RelayCommand(obj =>
                {
                    ReaderRepository.Delete(SelectedReader);
                    UpdateList();
                },
                obj => SelectedReader != null));

        public RelayCommand UpdateReadersCommand => updateReadersCommand ??
                (updateReadersCommand = new RelayCommand(obj =>
                {
                    UpdateList();
                }));
    }
}
