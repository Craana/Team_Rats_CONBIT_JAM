using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDone : MonoBehaviour
{
    [SerializeField] zeroPuzzleState zeropuzzleState;
    [SerializeField] onePuzzleState onepuzzleState;
    [SerializeField] twoPuzzleState twopuzzleState;
    [SerializeField] threePuzzleState threepuzzleState;
    [SerializeField] fourPuzzleState fourpuzzleState;

    GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");

        zeropuzzleState = player.transform.Find("ZeroPuzzleState(Clone)").GetComponent<zeroPuzzleState>();
        onepuzzleState = player.transform.Find("OnePuzzleState(Clone)").GetComponent<onePuzzleState>();
        twopuzzleState = player.transform.Find("TwoPuzzleState(Clone)").GetComponent<twoPuzzleState>();
        threepuzzleState = player.transform.Find("ThreePuzzleState(Clone)").GetComponent<threePuzzleState>();
        fourpuzzleState = player.transform.Find("FourPuzzleState(Clone)").GetComponent<fourPuzzleState>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // just here to test the PuzzleIsDone();

        if (collision.CompareTag("Player")) 
        {
            PuzzleIsDone();
        }
    }

    public void PuzzleIsDone() 
    {
        //Has to be done from the last puzzle state to the first

        gameObject.SetActive(false);

        if (threepuzzleState.puzzleDoneBool == true && fourpuzzleState.puzzleDoneBool == false) 
        {
            fourpuzzleState.puzzleDoneBool = true;
        }

        if (twopuzzleState.puzzleDoneBool == true && threepuzzleState.puzzleDoneBool == false) 
        {
            threepuzzleState.puzzleDoneBool = true;
        }
        
        if (onepuzzleState.puzzleDoneBool == true && twopuzzleState.puzzleDoneBool == false) 
        {
            twopuzzleState.puzzleDoneBool = true;
        }

        if (zeropuzzleState.puzzleDoneBool == true && onepuzzleState.puzzleDoneBool == false) 
        {
            onepuzzleState.puzzleDoneBool = true;
        }

        if (zeropuzzleState.puzzleDoneBool == false)
        {
            zeropuzzleState.puzzleDoneBool = true;
        }
    }
}
