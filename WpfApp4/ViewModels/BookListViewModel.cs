using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using WpfApp4.Models;
using WpfApp4.Core.Data.Repository;
using WpfApp4.Core.Command;

namespace WpfApp4.ViewModels
{
    public class BookListViewModel : BaseViewModel
    {
        private List<Book> books = new List<Book>();

        private RelayCommand deleteBookCommand;

        private RelayCommand updateBooksCommand;

        private Book selectedBook;

        public BookListViewModel(IBookRepository bookRepository)
        {
            BookRepository = bookRepository;
            UpdateList();
        }

        public Book SelectedBook
        {
            get => selectedBook;
            set
            {
                selectedBook = value;
                RaisePropertyChanged();
            }
        }

        public IBookRepository BookRepository;

        public List<Book> Books { 
            get => books;
            set
            {
                books = value;
                RaisePropertyChanged();
            }
        }

        private void UpdateList()
        {
            Books = BookRepository.GetAll().ToList();
        }

        public RelayCommand DeleteBookCommand
        {
            get => deleteBookCommand ??
                (deleteBookCommand = new RelayCommand(obj =>
                {
                    BookRepository.Delete(SelectedBook);
                    UpdateList();
                },
                obj => SelectedBook != null));
        }

        public RelayCommand UpdateBooksCommand
        {
            get => updateBooksCommand ??
                (updateBooksCommand = new RelayCommand(obj =>
                {
                    UpdateList();
                }));
        }
    }
}
