using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFlow.Domain.Model.Enum
{
    public enum Status : int
    {
        TO_START = 0,
        STARTED = 1,
        FINISHED = 2,
        NOT_CONCLUDED = 3
    }
}
