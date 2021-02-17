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

        public MoviesController(VideoStoreDbContext context, ILogger<MoviesController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> ListMovies(int page)
        {
            try
            {
                ICollection<Movie> movies = await _context.Movies.OrderBy(movie => movie.Title).Skip(page - 1).Take(8).ToListAsync();
                return View(movies);
            }
            catch (Exception e)
            {
                return View(e);
            }
        }
        public async Task<IActionResult> MovieDetails(int id)
        {
            try
            {
                Movie movie = await _context.Movies.Where(movie => movie.MovieId == id).FirstOrDefaultAsync();
                return View(movie);
            }
            catch (Exception e)
            {
                return View(e);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}