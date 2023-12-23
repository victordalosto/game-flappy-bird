using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public Text textScore;
    public Logic logic;

    private int playerScore = 0;



    public void IncreaseScore(int amount)
    {
        playerScore += amount;
        textScore.text = playerScore.ToString();
    }



    public void DecreaseScore(int amount)
    {
        playerScore -= amount;
        if (playerScore <= 0)
        {
            playerScore = 0;
            logic.endGame();
        }
        textScore.text = playerScore.ToString();

    }

}
