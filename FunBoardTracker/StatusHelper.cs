using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunBoardTracker.Jira;

namespace FunBoardTracker
{
    public static class StatusHelper
    {
        public static Status BoardStatusToJiraStatus(BoardStatus status)
        {
            switch (status)
            {
                case BoardStatus.Todo: 
                    return Status.Open;
                case BoardStatus.Doing:
                    return Status.InProgress;
                case BoardStatus.Test:
                    return Status.ReadyForQa;
                case BoardStatus.Done:
                    return Status.Resolved;
            }

            return Status.Open;
        }

        public static BoardStatus JiraStatusToBoardStatus(Status status)
        {
            switch (status)
            {
                case Status.Open:
                    return BoardStatus.Todo;
                case Status.InProgress:
                    return BoardStatus.Doing;
                case Status.ReadyForQa:
                case Status.QaInProgress:
                    return BoardStatus.Test;
                case Status.Resolved:
                case Status.Closed:
                    return BoardStatus.Done;
            }

            return BoardStatus.Todo;
        }
    }

    public enum BoardStatus
    {
        Todo,
        Doing,
        Test,
        Done
    }
}
