using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlappyBird.Models
{
    public class GameManager
    {
        public BirdModel Bird { get; private set; }
        private readonly int _gravity = 2;

        public async void MainLoop()
        {
            while (true)
            {
                Bird.Fall(_gravity);
                await Task.Delay(20); // wait 20ms
            }
        }

        public GameManager()
        {
            Bird = new BirdModel();
        }
    }
}
