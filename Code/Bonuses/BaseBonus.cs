using UnityEngine;

namespace Snake.Bonuses
{
    public abstract class BaseBonus : MonoBehaviour, IBonus
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Action(other.GetComponent<SnakeHead>());
            }
        }
        public abstract void Action(SnakeHead snake);
    }
}