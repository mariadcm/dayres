using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Gamecontroller : MonoBehaviour
{

    public int totalScore;
    public TextMeshProUGUI scoretext;
   public GameObject gameOver;
    
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
     public void ShowGameOver()
{
   gameOver.SetActive(true);
}



 public void RestartGame(string lvlName)
 {
     SceneManager.LoadScene(lvlName);
 }
}
    

    
 

