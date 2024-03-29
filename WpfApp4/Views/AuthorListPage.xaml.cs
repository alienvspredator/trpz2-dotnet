﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfApp4.Core.Data.Repository;
using WpfApp4.Models;
using WpfApp4.ViewModels;

namespace WpfApp4.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthorListPage.xaml
    /// </summary>
    public partial class AuthorListPage : Page
    {
        private readonly CreateBookViewModel createBookViewModel;

        public AuthorListPage(CreateBookViewModel createBookViewModel, LibraryContext context)
        {
            InitializeComponent();
            this.createBookViewModel = createBookViewModel;
            DataContext = new AuthorsViewModel(new AuthorRepository(context));
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Author selectedAuthor = (DataContext as AuthorsViewModel).SelectedAuthor;
            if (selectedAuthor != null)
            {
                createBookViewModel.AddAuthorCommand.Execute(selectedAuthor);
                NavigationService.GoBack();
            }
        }
    }
}
