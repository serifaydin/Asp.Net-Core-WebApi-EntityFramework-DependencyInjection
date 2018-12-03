using DataLibrary.Common.IdentityManagement;
using Microsoft.Extensions.DependencyInjection;

namespace DataLibrary.Common
{
    public static class IoC
    {
        public static void IoCCommonDataLibraryRegister(this IServiceCollection service)
        {
            service.AddTransient<ILoginUnitOfWork, LoginUnitOfWork>();
        }
    }
}