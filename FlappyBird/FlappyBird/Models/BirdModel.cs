using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FlappyBird.Models
{
    public class BirdModel : INotifyPropertyChanged
    {
        private int _distanceFromBottom = 100;
        private int JumpStrength { get; set; } = 50;
        public event PropertyChangedEventHandler PropertyChanged;


        public int DistanceFromBottom
        {
            get => _distanceFromBottom;
            private set
            {
                _distanceFromBottom = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DistanceFromBottom)));
            }
        }
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
