using System.Collections.Generic;
using System.Net.Http;
using TestProject.MSTest.Sample.Helpers.Models;

namespace TestProject.MSTest.Sample.Helpers.Facade
{
    public partial class UserFacade : Facade
    {
        public UserFacade(HttpClient client)
            : base(client)
        { }

        public ActionResult<List<User>> GetUsers()
        {
            var result = this.GetRequest<List<User>>("users");
            return result;
        }

        public ActionResult<User> DeleteUser(int id)
        {
            var result = this.DeleteRequest<User>($"user/{id}");
            return result;
        }

        public ActionResult<User> CreateUser(User user)
        {
            var result = this.PostRequest<User, User>("user", user);
            return result;
        }

        public ActionResult<User> UpdateUser(User user)
        {
            var result = this.PutRequest<User, User>("user", user);
            return result;
        }
    }
}
