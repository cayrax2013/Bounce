using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthOnePoint : MonoBehaviour
{
    private Health health;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        health = GameObject.FindGameObjectWithTag("HealthHandler").GetComponent<Health>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            health._Health += 1;
            Destroy(gameObject);
        }
    }
}
