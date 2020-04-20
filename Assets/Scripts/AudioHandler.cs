using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    [SerializeField] private AudioSource _pressButonSound;

    public void TurnOnPressButtonSound()
    {
        _pressButonSound.Play();
    }
}
