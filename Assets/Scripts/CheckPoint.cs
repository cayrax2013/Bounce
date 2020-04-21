using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private UnityEvent _camePlayer;

    private CheckPointsHandler _gameMaster;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _gameMaster = GameObject.FindGameObjectWithTag("gameMaster").GetComponent<CheckPointsHandler>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            _camePlayer?.Invoke();
            _gameMaster.lastCheckPointPos = transform.position;
            _spriteRenderer.enabled = false;
        }
    }
}
