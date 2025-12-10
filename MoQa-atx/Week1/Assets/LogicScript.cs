using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool birdIsAlive=true;

[ContextMenu("Skoru Arttir")]
    public void addScore(int scoreToAdd)
    {
        playerScore=playerScore+scoreToAdd;
        scoreText.text=playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        birdIsAlive=false;
    }
}
