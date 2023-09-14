using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highScoreText;

    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]

    public void Start()
    {
        UpdateHighScoreText();
    }

    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);

        if(playerScore > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", playerScore);
        }
        
    }
    public void UpdateHighScoreText()
    {
        highScoreText.text = $"HighScore: {PlayerPrefs.GetInt("highScore", 0)}";
    }

    public void deleteHighScore()
    {
        PlayerPrefs.DeleteKey("highScore");
    }
}