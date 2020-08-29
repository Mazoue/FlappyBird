using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlappyBird.Models
{
    public class BirdModel
    {
        public int DistanceFromBottom { get; private set; } = 100;
        public int JumpStrength { get; private set; } = 50;

        public void Fall(int gravity)
        {
            DistanceFromBottom -= gravity;
        }

        public void Jump()
        {
            if (DistanceFromBottom < 530)
                DistanceFromBottom += JumpStrength;
        }
    }
}
