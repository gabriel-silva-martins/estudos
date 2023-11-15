using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.DTOs;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmController : ControllerBase
    {
        private FilmContext _context;
        private IMapper _mapper;

        public FilmController(FilmContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddFilm([FromBody] CreateFilmDTO filmDTO)
        {
            Film film = _mapper.Map<Film>(filmDTO);
            _context.Films.Add(film);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetFilmById),
                new { id = film.Id },
                film);
        }

        [HttpGet]
        public IEnumerable<Film> GetAllFilm()
        {
            return _context.Films;
        }

        [HttpGet("{id}")]
        public IActionResult GetFilmById(int id)
        {
            var film = _context.Films.FirstOrDefault(films => films.Id == id);
            if (film == null) return NotFound();
            return Ok(film);
        }
    }
}
