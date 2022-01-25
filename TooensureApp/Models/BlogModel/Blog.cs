using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TooensureApp.Models.BlogModel
{
    public enum BlogType
    {
        None,
        Updates,
        Apps,
        Releases
    }
    public class Blog : BaseEntity
    {
        public string Src { get; set; }
        public string Sub { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string BlogType { get; set; }
        public string Url
        {
            get
            {
                return "Blogs/" + this.Id;
            }
        }
    }
}
