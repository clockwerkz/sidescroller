using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D rb;

    Animator anim;

    public float speed=1;
    private float input;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
	}

    void Update()
    {
        if (input != 0)
        {
            anim.SetBool("isRunning", true);
        } else
        {
            anim.SetBool("isRunning", false);
        }
        if (input > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (input < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }


	// Update is called once per frame
	void FixedUpdate () {
        
        //Get player's input
        input = Input.GetAxisRaw("Horizontal");
        
        //Moving player
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
	}
}
