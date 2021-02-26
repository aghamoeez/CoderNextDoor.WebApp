using CoderNextDoor.Data;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CoderNextDoor.DataAccess.Repository.IRepository
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<SelectListItem> GetUserListForDropDown();

        void LockUser(int userId);

        void UnLockUser(int userId);
    }
}