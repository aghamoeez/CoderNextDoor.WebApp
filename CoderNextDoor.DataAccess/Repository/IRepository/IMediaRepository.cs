using CoderNextDoor.Data;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CoderNextDoor.DataAccess.Repository.IRepository
{
    public interface IMediaRepository : IRepository<Media>
    {
        IEnumerable<SelectListItem> GetMediaListForDropDown();
    }
}