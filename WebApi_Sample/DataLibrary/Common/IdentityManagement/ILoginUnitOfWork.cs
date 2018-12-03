using DataModels.ResponseModel;

namespace DataLibrary.Common.IdentityManagement
{
    public interface ILoginUnitOfWork
    {
        AuthenticateModel Authenticate(string username, string password);
    }
}