using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp4.Core;
using WpfApp4.Models;

namespace WpfApp4.ViewModels
{
    class AuthorDetailsViewModel : BaseViewModel
    {
        #region Fields

        private Author currentAuthor;

        #endregion

        #region Properties

        public Author Author
        {
            get { return currentAuthor; }
            set
            {
                currentAuthor = value;
                RaisePropertyChanged();
            }
        }

        #endregion
    }
}
