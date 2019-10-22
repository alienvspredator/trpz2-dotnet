using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using WpfApp4.Models;
using WpfApp4.Core;
using WpfApp4.Network;

namespace WpfApp4.ViewModels
{
    class AuthorsViewModel : BaseViewModel
    {
        #region Fields

        private readonly IModelLoader modelLoader;

        private ObservableCollection<Author> authors;

        private Author selectedAuthor;

        #endregion

        #region Properties

        public ObservableCollection<Author> Authors
        {
            get { return authors; }
            set
            {
                authors = value;
                OnPropertyChanged("Authors");
            }
        }

        public Author SelectedAuthor
        {
            get => selectedAuthor;
            set
            {
                selectedAuthor = value;
                OnPropertyChanged("SelectedAuthor");
            }
        }

        #endregion

        public AuthorsViewModel()
        {
            modelLoader = new DatabaseModelLoader("trpz_admin", "aaa");

            Authors = modelLoader.LoadAuthors();
        }
    }
}
