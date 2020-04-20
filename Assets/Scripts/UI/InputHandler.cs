using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class InputHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private PlayerJumper _playerJumper;
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private float _direction;
    [SerializeField] private GameObject _mainMenuPanel;
    [SerializeField] private GameObject _levelsPanel;

    private bool _buttonIsPressed;

    public void QuitGame()
    {
        Application.Quit();
    }

    public void NavigateToLevelsTab()
    {
        _mainMenuPanel.SetActive(false);
        _levelsPanel.SetActive(true);
    }

    public void NavigateToMainMenu()
    {
        _mainMenuPanel.SetActive(true);
        _levelsPanel.SetActive(false);
    }

    public void StartLeve1()
    {
        SceneManager.LoadScene("Game");
    }

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
