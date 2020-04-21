using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Stakes : MonoBehaviour
{
    [SerializeField] private UnityEvent _cameAcrossToPlayer;
    [SerializeField] private int _damage = 1;
    [SerializeField] private CheckPointsHandler _checkPointsHandler;

    private GameObject _spawnPoint_1;

    private void Start()
    {
        _spawnPoint_1 = GameObject.FindGameObjectWithTag("SpawnPoint_1");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            _cameAcrossToPlayer?.Invoke();
            collision.transform.position = _checkPointsHandler.lastCheckPointPos;
            player.GetComponent<Health>().TakeDamage(_damage);
        }
    }
}
