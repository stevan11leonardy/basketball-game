using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameContoller : MonoBehaviour
{
    public static int score = 0;
    public Player player;
    public TextMeshProUGUI scoreText = default; 

    public float resetTimer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.holdingBall == false)
        {
            resetTimer -= Time.deltaTime;

            if (resetTimer <= 0)
            {
                SceneManager.LoadScene("BasketballGame");
            }
        }
    }

    public void addScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
