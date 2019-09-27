using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Core
{
    public class HistoryItem
    {
        public HistoryItem(Book book, Reader reader, string takeDate, string returnedDate, string realReturnedDate, string status)
        {
            Book = book;
            Reader = reader;
            ReturnedDate = returnedDate;
            RealReturnedDate = realReturnedDate;
            Status = status;
            TakeDate = takeDate;
        }

        private Book book;

        private Reader reader;

        private string returnedDate;

        private string realReturnedDate;

        private string status;

        private string takeDate;

        public Book Book { get => book; set => book = value; }
        public Reader Reader { get => reader; set => reader = value; }
        public string ReturnedDate { get => returnedDate; set => returnedDate = value; }
        public string RealReturnedDate { get => realReturnedDate; set => realReturnedDate = value; }
        public string Status { get => status; set => status = value; }
        public string TakeDate { get => takeDate; set => takeDate = value; }
    }
}
