using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _Context;
        public ActivitiesController(DataContext Context)
        {
            this._Context = Context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await _Context.Activities.ToListAsync();
        }

        [HttpGet("id")]
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return await _Context.Activities.FindAsync(id);
        }
    }
} 