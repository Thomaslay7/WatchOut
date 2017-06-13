using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider : MonoBehaviour {
	public AudioSource audio;


	// Use this for initialization
	public Image gambar;
	void Start () {
		gambar.sprite = Resources.Load<Sprite>("Shopitem/cm1") as Sprite;
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void ChangeImage(string imagename)
	{
		audio.Play ();
		gambar.sprite = Resources.Load<Sprite>("Shopitem/"+imagename) as Sprite;
	}
}
