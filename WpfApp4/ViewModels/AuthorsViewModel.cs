using System.Collections.Generic;
using System.Linq;
using WpfApp4.Models;
using WpfApp4.Core.Data.Repository;

namespace WpfApp4.ViewModels
{
    class AuthorsViewModel : BaseViewModel
    {
        #region Fields

        private List<Author> authors;

        private Author selectedAuthor;

        #endregion

        #region Properties

        IAuthorRepository Repository { get; set; }

        public List<Author> Authors
        {
            get => authors;
            set
            {
                authors = value;
                RaisePropertyChanged();
            }
        }

        public Author SelectedAuthor
        {
            get => selectedAuthor;
            set
            {
                selectedAuthor = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        private void UpdateList()
        {
            Authors = Repository.GetAll().ToList();
        }

        public AuthorsViewModel(IAuthorRepository authorRepository)
        {
            Repository = authorRepository;
            UpdateList();
        }
    }
}
