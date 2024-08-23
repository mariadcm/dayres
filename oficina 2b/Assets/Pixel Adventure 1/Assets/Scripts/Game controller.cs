using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Gamecontroller : MonoBehaviour
{

    public int totalScore;
    public Text scoreText;

    public static Gamecontroller instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void updateScoreText()
{
    scoreText.text = totalScore.ToString();
}
}

    