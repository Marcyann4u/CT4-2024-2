using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Rigidbody2D rb; // Elemento de física do Unity
    public float speed = 4.5f; // velocidade do player
    void Start()
    {
        rb = rb.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }


    void Move()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(Horizontal * speed, Vertical * speed);
    }

}
