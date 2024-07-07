﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interfaces
{
    public interface IBookRepository : IBaseRepository<Book>
    {
        Task<bool> ExistWithNameAsync(string name);
        Task<bool> ExistWithNameExceptIdAsync(int id, string name);
    }


}
