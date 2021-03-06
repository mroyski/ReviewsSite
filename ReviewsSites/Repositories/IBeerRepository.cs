﻿using System.Collections.Generic;
using ReviewsSites.Models;

namespace ReviewsSites.Repositories
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> GetAll();
        Beer GetById(int id);      
    }
}
