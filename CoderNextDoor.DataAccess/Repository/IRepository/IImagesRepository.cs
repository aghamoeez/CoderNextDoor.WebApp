using CoderNextDoor.Data;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CoderNextDoor.DataAccess.Repository.IRepository
{
    public interface IImagesRepository : IRepository<Images>
    {
        IEnumerable<SelectListItem> GetImagesListForDropDown();

        //     Task<bool> Update(Category catalogueEntity);
    }
}