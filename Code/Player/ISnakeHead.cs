using System;
using UnityEngine;

namespace Snake
{
    public interface ISnakeHead
    {
        IMovementParams MoveParams { get; }

        public void Move();
        public void TurnDown();
        public void TurnUp();
        public void TurnRight();
        public void TurnLeft();
    }
}
