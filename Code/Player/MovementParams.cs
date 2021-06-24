using Snake.Sides;
using UnityEngine;

namespace Snake
{
    public sealed class MovementParams : IMovementParams
    {
        public ISpeed Speed { get; }
        public bool isDead { get; set; }
        public Side Side {get; set;}

        public MovementParams(ISpeed speed)
        {
            isDead = false;
            Speed = speed;
            Side = Side.Up;
        }

        public void SpeedUp()
        {
            Speed.CurrentSpeed++;
        }
        public void SpeedDown()
        {
            Speed.CurrentSpeed--;
        }
        public void ChangeSpeed(float speed) 
        {
            Speed.CurrentSpeed = speed;
        }
        public void Death()
        {
            isDead = true;
        }
    }
}