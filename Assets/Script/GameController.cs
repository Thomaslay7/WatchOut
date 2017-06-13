using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public bool isGameOver;
  
  
    public Text GameOvertxt;
  
    public void GameOver(bool isgameover)
    {
        GameOvertxt.enabled = true;
    }

  }
