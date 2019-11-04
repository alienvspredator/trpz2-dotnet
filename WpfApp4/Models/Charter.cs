using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Models
{
    public partial class Charter : BaseEntity<int>
    {
        public string Title { get; set; }

        public virtual Book Book { get; set; }
    }
}
