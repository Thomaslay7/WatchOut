using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
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
    void Update () {
    }

    public void nunduk()
    {
        Debug.Log("croach!");
        StartCoroutine(crouch());

        collider.height = 151.3746f;
        collider.center = new Vector3(89.2f, -88.9f, 0f);
        // anim.SetBool("isNunduk", true);
    }

    IEnumerator crouch()
    {
        player.GetComponent<Animator>().SetBool("isNunduk", true);
        yield return new WaitForSeconds(0.25f);
        player.GetComponent<Animator>().SetBool("isNunduk", false);
        StopCoroutine(crouch());
    }
    /*  public void jump()
      {
          anim.SetBool("isJump", true);
      }*/
}
