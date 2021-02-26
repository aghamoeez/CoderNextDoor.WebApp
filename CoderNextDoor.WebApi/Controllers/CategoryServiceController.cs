using CoderNextDoor.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace CoderNextDoor.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryServiceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryServiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //[HttpGet]
        //public string Get()
        //{
        //    var z = "asd";
        //    return z;
        //}
        //[HttpGet]
        //public IEnumerable<CoderNextDoor.Data.Category> Get()
        //{
        //    var z = _unitOfWork.Category.GetAll();
        //    return z;
        //}
    }
}