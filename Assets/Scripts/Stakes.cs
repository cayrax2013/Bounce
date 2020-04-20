using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stakes : MonoBehaviour
{
    private GameObject spawnPoint_1;
    private Health health;
    private PlayerMover player;
    [SerializeField] private GameMaster _gameMaster;

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
            collision.transform.position = _gameMaster.lastCheckPointPos;
            //player.transform.position = spawnPoint_1.transform.position;
            health._Health -= 1;

        }
    }
}
