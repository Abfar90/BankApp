﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banken2023.Classes;

namespace Banken2023.Repo
{
    internal interface IUserRepo
    {
        Customer[] GetUsers();
    }
}
