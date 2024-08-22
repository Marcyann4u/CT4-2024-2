using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
   public Rigidbody2D rb;
   public float speedY;// numeros com virgula

    void Start()
    {
        rb.velocity = new Vector2(0, speedY);
    }


    void Update()
    {
        Camera camera = Camera.main;
        Vector3 posicaoNaCamera = camera .WorldToViewportPoint(this.transform.position);
        if(posicaoNaCamera.y > 1)
        {
            Destroy(this.gameObject);
        }
    }
}
