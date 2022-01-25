using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TooensureApp.Models
{
    public class BaseEntity
    {
        public int Id { get; set; } = 0;
        public string DateCreated { get; set; } = "";
    }
}
