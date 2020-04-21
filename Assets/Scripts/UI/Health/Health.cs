using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] private int _currentHealth;
    [SerializeField] Image[] _lifes;
    [SerializeField] private Sprite _filledLife;
    [SerializeField] private Sprite _emptyLife;

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;

        if (_currentHealth > _lifes.Length)
            _currentHealth = _lifes.Length;

        for (int i = 0; i < _lifes.Length; i++)
        {
            if (i < _currentHealth)
                _lifes[i].sprite = _filledLife;
            else
                _lifes[i].sprite = _emptyLife;
        }

        if (_currentHealth <= 0)
            SceneManager.LoadScene("Level1");
    }
}
