using DragRacing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRacing.Logic
{
	class RaceTrack
	{
		List<DragRacer> Racers = new List<DragRacer>();
		public int TrackLength { get; set; }
		public string TrackName { get; set; }

	}
}
