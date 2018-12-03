using DataModels.ResponseModel;
using System.Linq;

namespace DataLibrary.Common.IdentityManagement
{
    public class LoginUnitOfWork : ILoginUnitOfWork
    {
        private readonly SampleDatabaseContext _dbContext;
        public LoginUnitOfWork(SampleDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public AuthenticateModel Authenticate(string username, string password)
        {
            return (from user in _dbContext.MltpUser
                    where user.UserName == username && user.Password == password
                    select new AuthenticateModel
                    {
                        Id = user.Id,
                        Name = user.Name,
                        Surname = user.Surname,
                    }).FirstOrDefault();
        }
    }
}
