using CoderNextDoor.Data;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CoderNextDoor.DataAccess.Repository.IRepository
{
    public interface ICommentRepository : IRepository<Comment>
    {
        IEnumerable<SelectListItem> GetCommentListForDropDown();

        //   Task<bool> Update(Category catalogueEntity);
    }
}