using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiApp.Models;

namespace WebApiApp.Microservices.IService
{
    public interface IStory
    {
        public List<string> GetStoryIds();
        public StoryModel GetStory(string Id);
    }
}
