using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    public enum StatePlayer 
    {
        zeroPuzzle,
        onePuzzle,
        twoPuzzle,
        threePuzzle,
        fourPuzzle,
        fivePuzzle
    }

    [SerializeField] StatePlayer initialState;

    Dictionary<StatePlayer, PlayerState> playerStates = new Dictionary<StatePlayer, PlayerState>();

    MonoBehaviour currentState;

    [SerializeField] zeroPuzzleState zeropuzzleState;
    [SerializeField] onePuzzleState onepuzzleState;
    [SerializeField] twoPuzzleState twopuzzleState;
    [SerializeField] threePuzzleState threepuzzleState;
    [SerializeField] fourPuzzleState fourpuzzleState;
    [SerializeField] fivePuzzleState fivepuzzleState;

    Transform playerTransform;

    // Start is called before the first frame update
    void Awake()
    {
        playerTransform = GetComponent<Transform>();

        playerStates.Add(StatePlayer.zeroPuzzle, Instantiate(zeropuzzleState, playerTransform));
        playerStates.Add(StatePlayer.onePuzzle, Instantiate(onepuzzleState, playerTransform));
        playerStates.Add(StatePlayer.twoPuzzle, Instantiate(twopuzzleState, playerTransform));
        playerStates.Add(StatePlayer.threePuzzle, Instantiate(threepuzzleState, playerTransform));
        playerStates.Add(StatePlayer.fourPuzzle, Instantiate(fourpuzzleState, playerTransform));
        playerStates.Add(StatePlayer.fivePuzzle, Instantiate(fivepuzzleState, playerTransform));

        currentState = playerStates[initialState];
        currentState.gameObject.SetActive(true);

    }

    public void PlayerChangeState(StatePlayer state) 
    {
        currentState.gameObject.SetActive(false);
        currentState = playerStates[state];
        currentState.gameObject.SetActive(true);
    }
}
