using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerJump : MonoBehaviour {
    Animator anim;
    public GameObject player;

    CapsuleCollider collider;

    // Use this for initialization
    void Start()
    {
        collider = GetComponent<CapsuleCollider>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void jump()
    {
        Debug.Log("Jump!");
        collider.height = 237f;
        collider.center = new Vector3(89.2f, 85.66f, 0f);
        StartCoroutine(crouch());
        // anim.SetBool("isNunduk", true);
    }

    IEnumerator crouch()
    {
        player.GetComponent<Animator>().SetBool("isJump", true);
        yield return new WaitForSeconds(0.25f);
        player.GetComponent<Animator>().SetBool("isJump", false);
        StopCoroutine(crouch());
    }
}
