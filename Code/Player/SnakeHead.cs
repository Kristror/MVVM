using Snake.Sides;
using System;
using UnityEngine;

namespace Snake
{
    public class SnakeHead :MonoBehaviour, ISnakeHead
    {
        public IMovementParams MoveParams { get; set; }

        public Action SpawnPart;
        public Action Death;

        private void Awake()
        {
            MoveParams = new MovementParams(new Speed(15,3f));
        }
        
        public void SpawnAction(Action spawn)
        {
            SpawnPart = spawn;
        }
        public void DeathAction(Action death)
        {
            Death = death;
        }

        public void AddPart()
        {
            SpawnPart();
        }
        public void Move()
        {
            if (!MoveParams.isDead)
            {
                transform.position += transform.forward * MoveParams.Speed.CurrentSpeed * Time.deltaTime;
            }
        }
        public void SpeedUp()
        {
            MoveParams.SpeedUp();
        }
        public void TurnDown()
        {
            if(MoveParams.Side != Side.Up)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                MoveParams.Side = Side.Down;
            }
        }
        public void TurnUp()
        {
            if (MoveParams.Side != Side.Down)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                MoveParams.Side = Side.Up;
            }
        }
        public void TurnRight()
        {
            if (MoveParams.Side != Side.Left)
            {
                transform.rotation = Quaternion.Euler(0, 90, 0);
                MoveParams.Side = Side.Right;
            }
        }
        public void TurnLeft()
        {
            if (MoveParams.Side != Side.Right)
            {
                transform.rotation = Quaternion.Euler(0, 270, 0);
                MoveParams.Side = Side.Left;
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("SnakePart"))
            {
                MoveParams.Death();
                Death();
            }
        }
    }
}