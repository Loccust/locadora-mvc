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
      var movies = await _context.Movies.OrderBy(movie => movie.Title).Skip(page-1).Take(8).ToListAsync();
      return View(movies);
    }
    public async Task<IActionResult> MovieDetails(int id)
    {
      var movie = await _context.Movies.Where(movie => movie.MovieId == id).FirstOrDefaultAsync();
      return View(movie);
    }
  }
}