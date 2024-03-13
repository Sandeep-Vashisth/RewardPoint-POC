using System.Collections.Generic;
using WebApiApp.Microservices.IService;
using WebApiApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiApp.Microservices.Service
{
    public class Story : IStory
    {
        private List<string> Ids = new List<string>(); // caching..
        private List<StoryModel> storyModels = new List<StoryModel>();
        public StoryModel GetStory(string Id)
        {
            var result = storyModels.Where(x => x.Id == Id).SingleOrDefault();
            if(result != null)
            {
                return result;
            }
            // throw new System.NotImplementedException();
            // Get API Call using http Get Async
            // How to call get API using c#

            StoryModel storyModel = new StoryModel();
            storyModel.Id = Id;
            storyModel.Url = "https://www.google.com";

            storyModels.Add(storyModel);

            return storyModel;

        }

        public List<string> GetStoryIds()
        {
            if (Ids.Count() > 0)
            {
                return Ids;
            }

            // call get API and return the data;

            Ids.Add("233345");
            Ids.Add("233346");
            Ids.Add("233347");
            Ids.Add("233348");

            return Ids;
        }
    }
}
