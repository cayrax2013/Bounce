using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stakes : MonoBehaviour
{
    private GameObject spawnPoint_1;
    private Health health;
    private BallMover player;
    private GameMaster gm;

    private void Start()
    {
        health = GameObject.FindGameObjectWithTag("HealthHandler").GetComponent<Health>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<BallMover>();
        spawnPoint_1 = GameObject.FindGameObjectWithTag("SpawnPoint_1");
        gm = GameObject.FindGameObjectWithTag("gameMaster").GetComponent<GameMaster>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = gm.lastCheckPointPos;
            //player.transform.position = spawnPoint_1.transform.position;
            health._Health -= 1;
            Debug.Log(health._Health);
        }
    }
}
