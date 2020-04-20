using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Stakes : MonoBehaviour
{
    [SerializeField] private UnityEvent _cameAcrossToPlayer;
    
    private GameMaster _gameMaster;
    private GameObject spawnPoint_1;
    private Health health;
    private PlayerMover player;

    private void Start()
    {
        health = GameObject.FindGameObjectWithTag("HealthHandler").GetComponent<Health>();
        spawnPoint_1 = GameObject.FindGameObjectWithTag("SpawnPoint_1");
        //_gameMaster = GameObject.FindGameObjectWithTag("gameMaster").GetComponent<GameMaster>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            _cameAcrossToPlayer?.Invoke();
            collision.transform.position = _gameMaster.lastCheckPointPos;
            //player.transform.position = spawnPoint_1.transform.position;
            health._Health -= 1;

        }
    }
}
