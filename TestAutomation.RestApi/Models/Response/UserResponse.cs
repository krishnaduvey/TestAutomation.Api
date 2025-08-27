using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.RestApi.Models.Response
{
    public class UserResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string CreatedAt { get; set; }
    }
}
