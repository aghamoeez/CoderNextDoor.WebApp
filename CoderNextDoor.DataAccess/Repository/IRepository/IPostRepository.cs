using CoderNextDoor.Data;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CoderNextDoor.DataAccess.Repository.IRepository
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<SelectListItem> GetPostListForDropDown();
    }
}