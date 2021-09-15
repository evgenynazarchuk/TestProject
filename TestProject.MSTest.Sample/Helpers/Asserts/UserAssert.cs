using TestProject.MSTest.Sample.Helpers.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject.MSTest.Sample.Helpers.Asserts
{
    public static class UserAssert
    {
        public static void AssertThat(
            this User user, 
            int? id = null,
            string? name = null)
        {
            if (id is not null)
            {
                Assert.AreEqual(id, user.Id);
            }

            if (name is not null)
            {
                Assert.AreEqual(name, user.Name);
            }
        }
    }
}
