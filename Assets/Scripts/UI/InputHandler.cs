using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class InputHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private PlayerJumper _playerJumper;
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private GameObject _mainMenuPanel;
    [SerializeField] private GameObject _levelsPanel;
    [SerializeField] private float _direction;

    private bool _theButtonWasPressed;

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
        if (_mainMenuPanel != null)
        {
            _mainMenuPanel.SetActive(true);
            _levelsPanel.SetActive(false);
        }
        else
            SceneManager.LoadScene("MainMenu");
    }

    public void StartLeve1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _theButtonWasPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _theButtonWasPressed = false;
    }

    private void Update()
    {
        if (_theButtonWasPressed)
            _playerMover.Move(_direction);
    }
}
