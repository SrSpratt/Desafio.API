using Desafio.API.Data;
using Desafio.API.Models;
using Desafio.API.Entities;
using Desafio.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Desafio.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : BaseController<Product, Inventory>
    {
        public ProductController(Inventory repository) : base(repository) 
        {

        }

    }

}
