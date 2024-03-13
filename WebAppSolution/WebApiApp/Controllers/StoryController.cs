using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiApp.Microservices.IService;
using WebApiApp.Models;

namespace WebApiApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoryController : ControllerBase
    {
        readonly IStory _iStory;
        public StoryController(IStory istory)
        {
            _iStory = istory;
        }
        [HttpGet]
        public List<StoryModel> GetStory()
        {
            List<StoryModel> storyModels = new List<StoryModel>();
            var idList =_iStory.GetStoryIds();

            foreach(var id in idList)
            {
                var story = _iStory.GetStory(id);
                storyModels.Add(story);
            }
            return storyModels;
        }
    }
}
