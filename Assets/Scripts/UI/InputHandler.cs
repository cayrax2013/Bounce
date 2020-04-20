using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private PlayerJumper _playerJumper;
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private float _direction;

    private bool _buttonIsPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        _buttonIsPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _buttonIsPressed = false;
    }

    private void Update()
    {
        if (_buttonIsPressed)
        {
            _playerMover.Move(_direction);
        }
    }
}
