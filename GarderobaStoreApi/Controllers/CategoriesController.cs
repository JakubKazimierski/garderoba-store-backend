using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GarderobaStoreApi.Models;
using GarderobaStoreApi.Services;
using Microsoft.AspNetCore.Authorization;

namespace GarderobaStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
     
        private ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            var categories = await _categoriesService.GetAllCategories();
            return Ok(categories);
        }



        [HttpPost]
        //[Authorize]
        public async Task<ActionResult<Category>> AddCategory([FromBody] Category category)
        {
            //authorize to do

            var createdCategory = await _categoriesService.AddCategory(category);

            if (createdCategory != null)
            {
                return Ok(createdCategory);
            }
            return BadRequest(createdCategory);
        }

    }
}
