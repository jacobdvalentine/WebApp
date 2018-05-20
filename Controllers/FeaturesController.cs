using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.ContollerInterfaces;
using vega.Model;
using vega.Persistence;

namespace vega.Controllers
{
    public class FeaturesController: Controller
    {
        // Controller constructor
        private readonly VegaDbContext context;
        private readonly IMapper mapper;
        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        // GET method for aquiring features from database
        [HttpGet("/api/features")]
        public async Task<IEnumerable<IMake>> GetFeatures()
        {
            // This function waits until list is asyncously built to return
            var features = await context.Makes.Include(m => m.Models).ToListAsync();

            // Maps a Make list type to a IMake list type, return IEnumerable of mapped list
            return mapper.Map<List<Make>, List<IMake>>(features);
        }
    }  
    }
}