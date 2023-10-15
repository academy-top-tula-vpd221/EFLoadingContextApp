﻿using EFModrelCreateApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntityRelationsApp
{
    public class Position
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public virtual List<Employee> Employees { get; set; } = new();
    }
}
