using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiTest1
{
    public static class PlatformSource
    {
        public static Random random = new Random();

        public static PlatformMoveEvent GetRandom()
        {
            return new PlatformMoveEvent
            {
                Name = "move" + random.Next(0, 100),
                Duration=50,
                X = random.Next(0, 500),
                Y = random.Next(0, 50)
            };
        }

        public static IEnumerable<PlatformMoveEvent> GetRandomMoves()
        {
            return Enumerable.Range(5, random.Next(6, 10)).Select(x => GetRandom());
        }
    }
}
