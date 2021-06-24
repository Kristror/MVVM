using UnityEngine;

namespace Snake.Bonuses
{
    public class Apple : BaseBonus
    {
        private void Awake()
        {
            Relocate();
        }
        public override void Action(SnakeHead snake)
        {
            Relocate();
            snake.AddPart();
        }
        public void Relocate()
        {
            transform.position = new Vector3(Random.Range(-21,21),0, Random.Range(-16,16));
        }
    }
}
