using Kolokwium2.Exceptions;
using Kolokwium2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Services
{
    public class SqlServerMusicDbService : IMusicDbService
    {
        private readonly MusicDbContext _context;
        public SqlServerMusicDbService(MusicDbContext context)
        {
            _context = context;
        }

        public void AddMusician(Musician musician)
        {

            _context.Musicians.Add(musician);
            _context.SaveChanges();
        }

        public Musician GetMusicians(int id)
        {
            var musician =  _context.Musicians.SingleOrDefaultAsync(m => m.IdMusician == id);

            if (musician == null)
            {
                throw new MusicianDoesNotExistsException($"Musician with an id={id} does not exists");
            }

            return musician;
        }
    }
}
