using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class FinishGame : MonoBehaviour
{
    [SerializeField] private GameObject _finishPanel;
    [SerializeField] Image[] _stars;
    [SerializeField] private Sprite _filledStar;
    [SerializeField] private Sprite _emptyStar;
    [SerializeField] private GameObject _audioHandler;

    private AudioSource _finishMusic;

    private void Start()
    {
        _finishMusic = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            _finishPanel.SetActive(true);
            _audioHandler.SetActive(false);
            _finishMusic.Play();
            DisplayAchievemetns();
        }
    }

    private void DisplayAchievemetns()
    {
        var highScore = PlayerPrefs.GetInt("currentScore");

        for (int i = 0; i < _stars.Length; i++)
        {
            if (i < highScore)
                _stars[i].sprite = _filledStar;
            else
                _stars[i].sprite = _emptyStar;
        }
    }
}
