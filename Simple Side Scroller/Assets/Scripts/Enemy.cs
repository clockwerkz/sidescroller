using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float minSpeed = 2f;
    public float maxSpeed = 10f;
    private float speed;

	// Use this for initialization
	void Start () {
		speed = Random.Range(minSpeed, maxSpeed); 
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
	}

    void OnTriggerEnter2D(Collider2D hitObject)
    {
        if (hitObject.tag == "Player")
        {
            print("We hit the player!");
        }
    }
}
