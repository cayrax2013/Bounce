using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    [SerializeField] private GameObject _finishPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            _finishPanel.SetActive(true);
            _finishPanel.SetActive(false);
            SceneManager.LoadScene("MainMenu");
        }
    }
}
