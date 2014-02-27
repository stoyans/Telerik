using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystem
{
    class ChaoticParticle : Particle
    {
        private Random generateRandomSpeed;
        private const int speedLimit = 2;

        public ChaoticParticle(MatrixCoords position, MatrixCoords speed, Random randomSpeed) :
            base(position, speed)
        {
            this.generateRandomSpeed = randomSpeed;
        }

        public override char[,] GetImage()
        {
            return new char[,] { { '#' } };
        }

        public override IEnumerable<Particle> Update()
        {
            this.Speed = GetRandomCoords();
            return base.Update();
        }

        protected MatrixCoords GetRandomCoords()
        {
            int randomSpeedRow = this.generateRandomSpeed.Next(-speedLimit, speedLimit + 1);
            int randomSpeedCol = this.generateRandomSpeed.Next(-speedLimit, speedLimit + 1);

            var createdSpeed = new MatrixCoords
                (
                    randomSpeedRow,
                    randomSpeedCol
                );
            return createdSpeed;
        }
    }
}
