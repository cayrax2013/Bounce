using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private CheckPointsHandler gm;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("gameMaster").GetComponent<CheckPointsHandler>();
        transform.position = gm.lastCheckPointPos;
    }
}
