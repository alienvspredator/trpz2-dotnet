﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4.Models
{
    public partial class ReaderCard : BaseEntity<int>
    {
        public virtual Reader Owner { get; set; }
    }
}
