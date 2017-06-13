using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour {

    
    CapsuleCollider collider;
    float startColliderHeight = 0;

    Animator anim;
    public GameObject Character;  
    public KeyCode Jump = KeyCode.UpArrow;
    public KeyCode Jongkok = KeyCode.DownArrow;

    public float Speed = 6;
    int charStatus ;
    Vector3 MoveDirection;
    CharacterController myController;

	// Use this for initialization
	void Start () {
        Character.GetComponent<Animator>();
        collider = GetComponent<CapsuleCollider>();
        anim=GetComponent<Animator>();
    
    }
	
	// Update is called once per frame
	void Update () {
        charStatus = 0;
        MoveDirection = Vector3.zero;
        float centerY = collider.height / 6;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            charStatus = 1;

            collider.height = 3.6f;
            collider.center = new Vector3(-1.21f, 3f, 0f);
            Character.GetComponent<Animator>().SetBool("isJump", true);
            Debug.Log("lompat");
        }
        else
        {

            Character.GetComponent<Animator>().SetBool("isIdle", true);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            charStatus = 2;
            Character.GetComponent<Animator>().SetBool("isNunduk", true);

            collider.height = 4.22f;
            collider.center = new Vector3(-1.21f, -2.3f, 0.0f);
        }
        else
        {
            Character.GetComponent<Animator>().SetBool("isIdle", false);
        }
        if (charStatus == 1)
        {
            myController = GetComponent<CharacterController>();

            if (Input.GetKey(Jump))
            {
                
                MoveDirection = Vector3.up * Speed;
                collider.height = 4.53f;
                collider.center = new Vector3(-1.21f, 0.8f, 0f);

            }

        }
        else if (charStatus == 2)
        {
            if (Input.GetKey(Jongkok))
            {
                MoveDirection = Vector3.down * Speed;
               
                collider.height = 4.22f;
                collider.center = new Vector3(-1.21f, -2.3f, 0.0f);
            }
        }
           
        else if(charStatus == 0)
        {
            Character.GetComponent<Animator>().SetBool("isIdle", true);
            collider.center = new Vector3(-1.21f, -1.109641f, collider.center.z);

        }

    }
}
