using ButonStore.BusinessServices.Interface;
using ButonStore.DbEntityClasses;
using ButonStore.DataAccessRepository;
using ButonStore.DataAccessRepository.DateAccessInterfaceRepo;

namespace ButonStore.BusinessServices.Services
{
    public class UserLoginService : IUserLoginService
    {
        private readonly IPostgreSqlRepository<UserLoginDetail> _postgreSqlRepository;
        public UserLoginService(PostgreSqlRepository<UserLoginDetail> postgreSqlRepository)
        {
            _postgreSqlRepository = postgreSqlRepository;
        }

        public async void AddUserLoginDetails(UserLoginDetail userLoginDetail)
        {
            try
            {
                await _postgreSqlRepository.Add(userLoginDetail);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
