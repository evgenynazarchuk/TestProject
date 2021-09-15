using TestProject.MSTest.Sample.Helpers.Models;
using TestProject.MSTest.Sample.Helpers.Builder;

namespace TestProject.MSTest.Sample.Helpers.Facade
{
    public partial class UserFacade : Facade
    {
        public ActionResult<User> CreateUser(string? name = null)
        {
            var user = UserBuilder.BuildDefaultUser(name);
            var result = this.PostRequest<User, User>("user", user);

            return result;
        }
    }
}
