using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.Models
{
    public class MusicianTrack
    {
        public int IdMusicianTrack { get; set; }

        public int IdTrack { get; set; }

        public int IdMusician { get; set; }

        public Track Track { get; set; }
        public Musician Musician { get; set; }
    }
}

