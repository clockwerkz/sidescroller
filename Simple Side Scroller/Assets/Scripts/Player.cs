using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D rb;

    public float speed=1;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        //Get player's input
        float input = Input.GetAxisRaw("Horizontal");
        
        //Moving player
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
	}
}
