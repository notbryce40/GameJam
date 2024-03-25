using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public Sprite sprite1;
    public Sprite sprite2;

    public GameObject targetObject;

    private SpriteRenderer spriteRenderer;

    [ContextMenu("Increase Score")]

    private void Start()
    {
        //spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        UpdateSprite();
    }

    public void UpdateSprite()
    {
        SpriteRenderer spriteRenderer = targetObject.GetComponent<SpriteRenderer>();

        if (playerScore % 2 == 0)
        {
            spriteRenderer.sprite = sprite1;
        }
        else
        {
            spriteRenderer.sprite = sprite2;
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
