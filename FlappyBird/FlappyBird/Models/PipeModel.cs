using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FlappyBird.Models
{
    public class PipeModel : INotifyPropertyChanged
    {
        private int _distanceFromLeft = 500;
        public event PropertyChangedEventHandler PropertyChanged;

        public int DistanceFromBottom { get; private set; } = new Random().Next(1, 60);

        public int DistanceFromLeft
        {
            get => _distanceFromLeft;
            private set
            {
                _distanceFromLeft = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DistanceFromLeft)));
            }
        }

        public bool IsCentered()
        {
            // half of the game width minus the width of the bird
            const int centerMin = 500 / 2 - 60;
            // half of the game width plus half the width of the bird
            const int centerMax = (500 + 60) / 2;
            return (DistanceFromLeft > centerMin && DistanceFromLeft < centerMax);
        }

        public void Move(int speed)
        {
            DistanceFromLeft -= speed;
        }

    }
}
