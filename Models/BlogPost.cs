using Newtonsoft.Json;
using System.Collections.Generic;

namespace website_webapi.Models 
{
    public class BlogPost {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "tags")]
        public string[] Tags { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }

        [JsonProperty(PropertyName = "isBlurb")]
        public bool IsBlurb { get; set; }

        [JsonProperty(PropertyName = "relatedPosts")]
        public List<BlogPost> RelatedPosts { get; set; }

        // how many characters to show if IsBlurb
        public static int BlurbLength = 75;

        [JsonConstructor]
        public BlogPost(int id, string content = "", bool isBlurb = false)
        {
            Id = id;
            IsBlurb = isBlurb;
            Content = content;
            RelatedPosts = new List<BlogPost>();
        }

        public BlogPost()
        {
        }
    }
}