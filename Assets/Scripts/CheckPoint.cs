using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private GameMaster gameMaster;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        gameMaster = GameObject.FindGameObjectWithTag("gameMaster").GetComponent<GameMaster>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            gameMaster.lastCheckPointPos = transform.position;
            spriteRenderer.enabled = false;
        }
    }
}
