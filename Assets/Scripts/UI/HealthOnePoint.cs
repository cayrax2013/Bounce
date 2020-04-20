using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthOnePoint : MonoBehaviour
{
    [SerializeField] private UnityEvent _cameAcrossToPlayer;

    private Health health;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        health = GameObject.FindGameObjectWithTag("HealthHandler").GetComponent<Health>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            _cameAcrossToPlayer?.Invoke();
            health._Health += 1;
            Destroy(gameObject);
        }
    }
}
