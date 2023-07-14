using ButonStore.DbEntityClasses;

namespace ButonStore.BusinessServices.Interface
{
    public interface IUserLoginService
    {
        void AddUserLoginDetails(UserLoginDetail userLoginDetail);
    }
}
