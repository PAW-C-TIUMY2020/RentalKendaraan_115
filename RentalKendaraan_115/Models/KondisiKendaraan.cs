﻿using System;
using System.Collections.Generic;

namespace RentalKendaraan_115.Models
{
    public partial class KondisiKendaraan
    {
        public KondisiKendaraan()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        public int IdKondisi { get; set; }
        public string NamaKondisi { get; set; }

        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
