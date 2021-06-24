using Snake.Bonuses;
using UnityEngine;

namespace Snake {
    public class GameContoller : MonoBehaviour
    {
        InputController _InputController;
        Snake _snake;
        [SerializeField]DeathUI _deathUI;


        private void Awake()
        {
            Time.timeScale = 1;
            Object.Instantiate(Resources.Load<Apple>("Apple"));
            _snake = new Snake(_deathUI.Death);
            _InputController = new InputController(_snake);
        }
        private void Update()
        {
            _InputController.Execute();
        }
    }
}