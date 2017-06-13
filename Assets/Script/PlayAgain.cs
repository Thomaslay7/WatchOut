using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void playAgaain()
    {
        Application.LoadLevel("kepalaSekolah");
    }
    public void keluar()
    {
        Application.Quit();

    }
    public void menu()
    {
        Application.LoadLevel("menu");
    }
}
