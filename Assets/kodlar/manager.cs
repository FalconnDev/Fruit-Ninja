using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class manager : MonoBehaviour
{
    public int score;

    public TextMeshProUGUI ScoreText;
    void Start()
    {
        
    }

    void Update()
    {
        gameScore();
    }

    private void gameScore()
    {
        ScoreText.text = score.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
