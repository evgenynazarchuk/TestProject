using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.MSTest.Sample.Helpers.Models;

namespace TestProject.MSTest.Sample.Helpers.Builder
{
    public static class UserBuilder
    {
        public static User BuildDefaultUser(string? name = null)
        {
            var user = new User
            {
                Name = name ?? "DefaultName"
            };

            return user;
        }
    }
}
