using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DeathUI : MonoBehaviour
{
    [SerializeField] Button restart;
    private void Awake()
    {
        gameObject.SetActive(false);
        restart.onClick.RemoveAllListeners();
        restart.onClick.AddListener(() => SceneManager.LoadScene(SceneManager.GetActiveScene().name));
    }

    public void Death()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}