using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventInt : UnityEvent<int> { }
public class Score : MonoBehaviour
{
    [SerializeField] private UnityEventInt _onScoreChanged;
    [SerializeField] private int _currentScore;

    public void TakeScore(int score)
    {
        _currentScore += score;
        PlayerPrefs.SetInt("currentScore", _currentScore);
        _onScoreChanged?.Invoke(_currentScore);
    }
}
