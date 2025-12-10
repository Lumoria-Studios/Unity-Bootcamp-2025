using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class canv : MonoBehaviour
{
    public int oyunSkor;
    public Text Skor;
    public GameObject bittiekran;

    public void addScore()
    {
        oyunSkor += 1;
        Skor.text = oyunSkor.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);



    }
    public void bitti()
    {
        bittiekran.SetActive(true);

    }

}
