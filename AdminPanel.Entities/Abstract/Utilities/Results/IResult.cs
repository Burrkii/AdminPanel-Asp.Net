﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPanel.Entities.Abstract.Utilities
{
    public interface IResult
    {
        bool Succes { get; }

        string Message { get; }
    }
}
