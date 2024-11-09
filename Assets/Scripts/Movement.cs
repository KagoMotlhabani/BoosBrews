using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script is for testing purposes only (not for the player to use)

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(x*speed, rb.velocity.y);
    }
}
