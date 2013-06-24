using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunBoardTracker.Jira
{
    public enum Status
    {
        Open = 1,
        InProgress = 3,
        ReadyForQa = 10004,
        QaInProgress = 10005,
        Resolved = 5,
        Closed = 6,
    }
}
