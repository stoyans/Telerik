using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    class ParticleSystemMain
    {
        const int SimulationRows = 30;
        const int SimulationCols = 40;

        static void Main(string[] args)
        {

            var renderer = new ConsoleRenderer(SimulationRows, SimulationCols);
            var particleOperator = new ParticleUpdater();

            var particles = new List<Particle>()
            {
                new Particle(new MatrixCoords(5,5), new MatrixCoords(1, 1)),
                new ParticleEmitter(new MatrixCoords(5,10), new MatrixCoords(0, 0), new Random())
                
            };

            var engine = new Engine(renderer, particleOperator, particles);

            engine.Run();
        }
    }
}
