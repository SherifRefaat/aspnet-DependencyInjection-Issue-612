using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.Core.Repositories;

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    public class DummyController : Controller
    {
        readonly DummyRepository _repo;

        public DummyController(DummyRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("")]
        public IEnumerable<string> Get()
        {
            return _repo.Fetch();
        }
    }
}
