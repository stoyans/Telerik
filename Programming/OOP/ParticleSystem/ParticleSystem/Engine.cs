using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParticleSystem
{
    public class Engine
    {
        private IParticleOperator particleOperator;

        private List<Particle> particles;

        private IRenderer renderer;

        private int waitMsPerTick;

        public Engine(IRenderer renderer, IParticleOperator particleOperator, List<Particle> particles = null, int waitMs = 100)
        {
            this.renderer = renderer;
            this.particleOperator = particleOperator;

            if (particles != null)
            {
                this.particles = particles;
            }
            else
            {
                this.particles = new List<Particle>();
            }

            this.waitMsPerTick = waitMs;
        }

        public void AddParticle(Particle p)
        {
            this.particles.Add(p);
        }

        public void Run()
        {
            while (true)
            {
                renderer.RenderAll();
                renderer.ClearQueue();

                List<Particle> producedParticle = new List<Particle>();

                foreach (var particle in particles)
                {
                    producedParticle.AddRange(particleOperator.OperateOn(particle));
                }

                foreach (var particle in this.particles)
                {
                    renderer.EnqueueForRendering(particle);
                }

                this.particles.RemoveAll(p => !p.Exists);

                this.particles.AddRange(producedParticle);
                particleOperator.TickEnded();

                Thread.Sleep(this.waitMsPerTick);
                
            }
        }
    }
}
