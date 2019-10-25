using System;
using System.Linq;
using WpfApp4.Core.Command;
using WpfApp4.Core.Data.Repository;
using WpfApp4.Models;
using WpfApp4.Core.Validation;

namespace WpfApp4.ViewModels
{
    public class CreateBookViewModel : BaseViewModel
    {
        private IBookRepository BookRepository { get; }

        private RelayCommand createBookCommand;

        private RelayCommand updateBookCommand;
        
        private RelayCommand addAuthorCommand;

        private BookValidator BookValidator { get; }

        public CreateBookViewModel(IBookRepository bookRepository)
        {
            BookRepository = bookRepository;
            EditableBook = new Book() { ReleaseDate = DateTime.Now };
            BookValidator = new BookValidator(EditableBook);
        }

        public CreateBookViewModel(IBookRepository bookRepository, Book editableBook)
        {
            BookRepository = bookRepository;
            EditableBook = editableBook;
            BookValidator = new BookValidator(EditableBook);
        }

        public Book EditableBook { get; set; }

        public RelayCommand CreateBookCommand
        {
            get => createBookCommand ??
                (createBookCommand = new RelayCommand(obj =>
                {
                    BookRepository.Create(EditableBook);
                },
                obj => BookValidator.Validate()));
        }

        public RelayCommand UpdateBookCommand
        {
            get => updateBookCommand ??
                (updateBookCommand = new RelayCommand(obj =>
                {
                    BookRepository.Update(EditableBook);
                },
                obj => BookValidator.Validate()));
        }

        public RelayCommand AddAuthorCommand
        {
            get => addAuthorCommand ??
                (addAuthorCommand = new RelayCommand(obj =>
                {
                    EditableBook.Authors.Add(obj as Author);
                },
                 obj => EditableBook.Authors.Where(a => a.Id == (obj as Author).Id).Count() == 0));
        }
    }
}
