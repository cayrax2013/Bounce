using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPointsHandler : MonoBehaviour
{
    private static CheckPointsHandler _instance;
    public Vector2 lastCheckPointPos;
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(_instance);
        }
        else
            Destroy(gameObject);
    }
}
