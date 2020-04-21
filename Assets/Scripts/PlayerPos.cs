using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private CheckPointsHandler checkPointHandler;

    private void Start()
    {
        checkPointHandler = GameObject.FindGameObjectWithTag("gameMaster").GetComponent<CheckPointsHandler>();
        transform.position = checkPointHandler.lastCheckPointPos;
    }
}
