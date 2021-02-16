using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VideoStore.Model;
using VideoStore.Data;
using Microsoft.EntityFrameworkCore;

namespace VideoStore.Controllers
{
    public class MoviesController : Controller
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly VideoStoreDbContext _context;

        public MoviesController(VideoStoreDbContext context, ILogger<MoviesController> logger){
            _context = context;
            _logger = logger;
        }

        //GET: Movies
        public async Task<IActionResult> Index(int? categoryId)
        {
            return View(await _context.Movies.ToListAsync());
        }
    }
}