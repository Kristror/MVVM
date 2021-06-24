using UnityEngine;

namespace Snake 
{
    public class InputController 
    {
        private Snake _snake;

        public InputController(Snake snake)
        {
            _snake = snake;
        }

        public void Execute()
        {
            _snake.Move();

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _snake.TurnDown();
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _snake.TurnUp();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                _snake.TurnRight();
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _snake.TurnLeft();
            }
        }
    }
}