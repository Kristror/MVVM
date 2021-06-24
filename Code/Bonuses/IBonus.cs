using UnityEngine;

namespace Snake.Bonuses
{
    public interface IBonus
    {
        public abstract void Action(SnakeHead snake);
    }
}