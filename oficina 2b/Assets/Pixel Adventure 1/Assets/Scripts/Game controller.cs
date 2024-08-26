using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamecontroller : MonoBehaviour
{

    public int totalScore;
    public Text scoretext;

    public static Gamecontroller instance;

    // Start is called before the first frame update
    void Start()
    {
       instance = this;
    }

  public void UpdateScoreText()
 {
      scoretext.text = totalScore.ToString();
     }
}



    

    
 

