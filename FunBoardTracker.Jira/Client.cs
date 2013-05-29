using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FunBoardTracker.Jira.Greenhopper;
using Newtonsoft.Json;

namespace FunBoardTracker.Jira
{
    public class Client
    {
        SimpleRestClient simpleRestClient;

        public Client()
        {
            simpleRestClient = new SimpleRestClient("https://jira.funda.nl/", new NetworkCredential("marius", "appeltaart123!"));
        }

        public List<RapidView> GetRapidViews()
        {
            var data = simpleRestClient.Get<RapidViewRoot>("rest/greenhopper/1.0/rapidviews/list");
            return data.Views;
        }

        public RapidView GetRapidView(int id)
        {
            var data = simpleRestClient.Get<RapidView>(String.Format("rest/greenhopper/1.0/rapidview/{0}", id));
            return data;
        }

        public List<Sprint> GetSprintsByRapidViewId(int id)
        {
            var data = simpleRestClient.Get<SprintRoot>(String.Format("rest/greenhopper/1.0/sprints/{0}", id));
            return data.Sprints;
        }

        public SprintReport GetSprintReport(int rapidViewId, int sprintId)
        {
            var data = simpleRestClient.Get<SprintReport>(String.Format("rest/greenhopper/1.0/rapid/charts/sprintreport?rapidViewId={0}&sprintId={1}", rapidViewId, sprintId));
            return data;
        }
    }
}
