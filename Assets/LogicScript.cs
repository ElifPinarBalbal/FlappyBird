using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;   // B�ylece ileride, farkl� puanlar ekletebilirizz
        scoreText.text = playerScore.ToString();

    }
}
