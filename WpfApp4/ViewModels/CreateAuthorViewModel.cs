﻿using WpfApp4.Core.Command;
using WpfApp4.Core.Data.Repository;
using WpfApp4.Core.Validation;
using WpfApp4.Models;

namespace WpfApp4.ViewModels
{
    public class CreateAuthorViewModel : BaseViewModel
    {
        private IAuthorRepository AuthorRepository { get; }

        private RelayCommand createAuthorCommand;

        private RelayCommand updateAuthorCommand;

        private AuthorValidator AuthorValidator { get; }

        public CreateAuthorViewModel(IAuthorRepository authorRepository)
        {
            AuthorRepository = authorRepository;
            EditableAuthor = new Author();
            AuthorValidator = new AuthorValidator(EditableAuthor);
        }

        public CreateAuthorViewModel(IAuthorRepository authorRepository, Author authorToEdit)
        {
            AuthorRepository = authorRepository;
            EditableAuthor = authorToEdit;
            AuthorValidator = new AuthorValidator(EditableAuthor);
        }

        public Author EditableAuthor { get; set; }

        public RelayCommand CreateAuthorCommand => createAuthorCommand ??
                (createAuthorCommand = new RelayCommand(obj =>
                {
                    AuthorRepository.Create(EditableAuthor);
                },
                obj => AuthorValidator.Validate()));

        public RelayCommand UpdateAuthorCommand => updateAuthorCommand ??
                (updateAuthorCommand = new RelayCommand(obj =>
                {
                    AuthorRepository.Update(EditableAuthor);
                },
                obj => AuthorValidator.Validate()));
    }
}
