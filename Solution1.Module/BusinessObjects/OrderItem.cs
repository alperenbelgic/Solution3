﻿using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class OrderItem
    {
        [Browsable(false)]
        [Key]
        public int Id { get; set; }

        public virtual Product Product { get; set; }

        public int Count { get; set; }

    }
}
