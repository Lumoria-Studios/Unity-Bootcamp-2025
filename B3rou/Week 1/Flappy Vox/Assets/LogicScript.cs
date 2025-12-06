using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;


    [ContextMenu("Increase Score")]
    void Start()
    {
        updateText();
    }
    public void addScore(int points)
    {
        playerScore += points;
        updateText();
    }
    public void updateText()
    {
        scoreText.text = "Score: " + playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen.SetActive(false);
        playerScore = 0;
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
