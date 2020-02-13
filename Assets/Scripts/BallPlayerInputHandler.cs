using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPlayerInputHandler : MonoBehaviour
{
    public BallMover BallMover;

    [SerializeField] private string verticalAxis = "Vertical";
    [SerializeField] private string horizontalAxis = "Horizontal";


    // Update is called once per frame
    private void Update()
    {
        if (BallMover != null)
        {
            Vector2 input = new Vector2(Input.GetAxis(horizontalAxis), Input.GetAxis(verticalAxis));
            BallMover.Move(input, Input.GetKeyDown(KeyCode.Space));
        }
        else
        {
            throw new System.NullReferenceException("ЕБАЛАЙ, ИДИОТ");
        }
    }
}
