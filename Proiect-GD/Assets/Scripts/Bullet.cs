﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D bulletRigidbody;
    public Collider2D bulletCollider;
    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody.velocity = transform.right * speed;
    }

    private void Update()
    {
        collisionEffects();
    }

    private void collisionEffects()
    {
        if (bulletCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            Destroy(gameObject);
        }

        if (bulletCollider.IsTouchingLayers(LayerMask.GetMask("Boxes")))
        {
            Destroy(gameObject);
        }

        if (bulletCollider.IsTouchingLayers(LayerMask.GetMask("tram-left")))
        {
            print("tramp");
            bulletRigidbody.velocity = transform.right * -speed;
        }

        if (bulletCollider.IsTouchingLayers(LayerMask.GetMask("tram-right")))
        {
            print("tramp");
            bulletRigidbody.velocity = transform.right * speed;
        }

        if (bulletCollider.IsTouchingLayers(LayerMask.GetMask("tram-up")))
        {
            print("tramp");
            bulletRigidbody.velocity = transform.up * speed;
        }

        if (bulletCollider.IsTouchingLayers(LayerMask.GetMask("tram-down")))
        {
            print("tramp");
            bulletRigidbody.velocity = transform.up * -speed;
        }
    }

//private void OnTriggerEnter2D()
//    {
        
//    }

}
