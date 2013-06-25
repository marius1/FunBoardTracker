using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FunBoardTracker.Jira.Greenhopper;
using FunBoardTracker.Jira.Search;
using Newtonsoft.Json;
using System.Configuration;

namespace FunBoardTracker.Jira
{
    public class Client
    {
        private SimpleRestClient simpleRestClient;

        public Client()
        {
            string username = ConfigurationManager.AppSettings["JiraUsername"];
            string password = ConfigurationManager.AppSettings["JiraPassword"];
            string baseUrl = ConfigurationManager.AppSettings["JiraBaseUrl"];

            simpleRestClient = new SimpleRestClient(baseUrl, new NetworkCredential(username, password));
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

        public Dictionary<string, int> GetSprintOrder(int sprintId)
        {
            var data = simpleRestClient.Get<Results>(String.Format("rest/api/2/search?jql=Sprint%20%3D%20{0}%20ORDER%20BY%20Rank&fields=key&maxResults=500", sprintId));
            
            Dictionary<string, int> order = new Dictionary<string, int>();
            int i = 1;
            foreach (Search.Issue issue in data.Issues)
            {
                order[issue.Key] = i++;
            }

            return order;
        }

        private bool DoTransition(string key)
        {
            string postData = "{\"transition\": { \"id\": \"{0}\"}}";
            return false;
        }
    }
}
