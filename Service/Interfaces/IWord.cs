﻿using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IWord
    {
        List<Words> GetAll();

        DetailWords GetByCourseID(int ID);
    }
}