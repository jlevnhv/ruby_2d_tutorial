﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public ParticleSystem collectionEffect;
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>(); 

        if (controller != null && controller.health < controller.maxHealth)
        {
            controller.ChangeHealth(1);
            Instantiate(collectionEffect, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
            controller.PlaySound(collectedClip);
        }
    }
}
