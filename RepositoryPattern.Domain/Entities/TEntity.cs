﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Domain.Entities
{
    public abstract class TEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } 
    }
}
