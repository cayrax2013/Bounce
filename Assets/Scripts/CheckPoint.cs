using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckPoint : MonoBehaviour
{
    private CheckPointsHandler _gameMaster;
    private SpriteRenderer _spriteRenderer;
    private AudioSource _audioSource;
    private bool _onePlayMusic = true;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _gameMaster = GameObject.FindGameObjectWithTag("gameMaster").GetComponent<CheckPointsHandler>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            PlaySound();
            _gameMaster.lastCheckPointPos = transform.position;
            _spriteRenderer.enabled = false;
        }
    }

    private void PlaySound()
    {
        if (_onePlayMusic)
        {
            _audioSource.Play();
            _onePlayMusic = false;
        }
    }
}
