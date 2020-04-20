using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    [SerializeField] private AudioSource _pressButonSound;
    [SerializeField] private AudioSource _catchedCoinSound;
    [SerializeField] private AudioSource _jumpedSound;
    [SerializeField] private AudioSource _reachedCheckPointSound;
    [SerializeField] private AudioSource _cameAcrossToStakesSound;
    [SerializeField] private AudioSource _catchedHealthSound;

    public void TurnOnPressButtonSound()
    {
        _pressButonSound.Play();
    }

    public void PlayCatchedCoinSound()
    {
        _catchedCoinSound.Play();
    }

    public void PlayJumpedSound()
    {
        _jumpedSound.Play();
    }

    public void PlayReachedCheckPointSound()
    {
        _reachedCheckPointSound.Play();
    }

    public void PlayCameAcrossToStakes()
    {
        _cameAcrossToStakesSound.Play();
    }

    public void PlayCatchedHealth()
    {
        _catchedHealthSound.Play();
    }
}
