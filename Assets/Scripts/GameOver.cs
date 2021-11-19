using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private GameObject snake;
    public void GameOverScreen()
    {
        gameOverUI.SetActive(true);
        snake.GetComponent<SnakeMove>();
        snake.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Retry()
    {
        SceneManager.LoadScene(0);
    }
}
