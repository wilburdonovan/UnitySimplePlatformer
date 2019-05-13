using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracterMove : MonoBehaviour {

    public float speed;
    private float moveInput;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        moveInput = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(moveInput * speed , rb.velocity.y);
	}
}
