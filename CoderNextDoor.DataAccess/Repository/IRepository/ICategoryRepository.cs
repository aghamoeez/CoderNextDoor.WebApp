using CoderNextDoor.Data;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CoderNextDoor.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<SelectListItem> GetCategoryListForDropDown();

        // Task<bool> Update(Category catalogueEntity);
    }
}