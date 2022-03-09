using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onePuzzleState : PlayerState
{
    PlayerStateMachine.StatePlayer onePuzzle = PlayerStateMachine.StatePlayer.onePuzzle;
    PlayerStateMachine.StatePlayer twoPuzzle = PlayerStateMachine.StatePlayer.twoPuzzle;
    PlayerStateMachine.StatePlayer threePuzzle = PlayerStateMachine.StatePlayer.threePuzzle;
    PlayerStateMachine.StatePlayer fourPuzzle = PlayerStateMachine.StatePlayer.fourPuzzle;
    PlayerStateMachine.StatePlayer fivePuzzle = PlayerStateMachine.StatePlayer.fivePuzzle;

    PlayerStateMachine playerStateMachine;

    public bool puzzleDoneBool = false;

    // Start is called before the first frame update
    void Start()
    {
        playerStateMachine = GetComponentInParent<PlayerStateMachine>();
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzleDoneBool == true)
        {
            playerStateMachine.PlayerChangeState(twoPuzzle);
        }
    }
}
