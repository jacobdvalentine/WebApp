using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.ContollerInterfaces;
using vega.Models;
using vega.Persistence;

namespace vega.Controllers
{
    public class MakesController : Controller
    {
        // Controller constructor
        private readonly VegaDbContext context;
        private readonly IMapper mapper;
        public MakesController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        // GET method for aquiring makes from database
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<IMake>> GetMakes()
        {
            // This function waits until list is asyncously built to return
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();

            // Maps a Make list type to a IMake list type, return IEnumerable of mapped list
            return mapper.Map<List<Make>, List<IMake>>(makes);
        }
    }
}