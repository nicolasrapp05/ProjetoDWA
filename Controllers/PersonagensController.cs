using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoDWA.Data;

namespace ProjetoDWA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonagensController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public PersonagensController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}