using Snake.Sides;
using UnityEngine;

namespace Snake
{
    public interface IMovementParams
    {
        ISpeed Speed { get; }
        bool isDead { get; }
        public Side Side { get; set; }

        public void SpeedUp();
        public void SpeedDown();
        public void ChangeSpeed(float speed);
        public void Death();
    }
}