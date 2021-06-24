using UnityEngine;
using System.Collections.Generic;

namespace Snake
{
    public class Snake 
    {
        List<GameObject> _snakeParts;
        List<Vector3> _snakePath;
        SnakeHead _snakeHead;
        Transform _Snakeroot;
        int delay = 100;
        public Snake(System.Action death)
        {
            _Snakeroot = new GameObject("Snake").transform;
            _snakeParts = new List<GameObject>();
            _snakeParts.Add(null);
            _snakePath = new List<Vector3>();
            _snakeHead = Object.Instantiate(Resources.Load<SnakeHead>("SnakeHead"),Vector3.zero,Quaternion.identity,_Snakeroot);
            _snakeHead.SpawnAction(AddPart); 
            _snakeHead.DeathAction(death);
        }
        public void AddPart()
        {
            _snakeParts.Add(Object.Instantiate(Resources.Load<GameObject>("SnakePart"), Vector3.zero, Quaternion.identity, _Snakeroot));
            if (_snakeParts.Count % 3 == 0) 
            {
                _snakeHead.SpeedUp();
                if(delay > 30)
                {
                    delay -= 5; 
                }
            };
        }
        public void Move()
        {
            _snakePath.Insert(0, _snakeHead.transform.position);
            _snakeHead.Move();
            for (int i = 1; i < _snakeParts.Count; i++)
            {
                if (_snakeParts[i] != null)
                {
                    _snakeParts[i].transform.position = _snakePath[i * delay];
                }
            }
            if (_snakePath.Count> _snakeParts.Count * delay)
            {
                _snakePath.RemoveAt(_snakePath.Count - 1);
            }
        }
        public void TurnDown()
        {
            _snakeHead.TurnDown();
        }
        public void TurnUp()
        {
            _snakeHead.TurnUp();
        }
        public void TurnRight()
        {
            _snakeHead.TurnRight();
        }
        public void TurnLeft()
        {
            _snakeHead.TurnLeft();
        }     
    }
}
