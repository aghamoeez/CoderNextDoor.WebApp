using CoderNextDoor.Data;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CoderNextDoor.DataAccess.Repository.IRepository
{
    public interface ITagRepository : IRepository<Tag>
    {
        IEnumerable<SelectListItem> GetTagListForDropDown();
    }
}