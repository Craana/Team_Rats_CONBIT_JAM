using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinConditionFive : MonoBehaviour
{
    [SerializeField] zeroPuzzleState zeropuzzleState;
    [SerializeField] onePuzzleState onepuzzleState;
    [SerializeField] twoPuzzleState twopuzzleState;
    [SerializeField] threePuzzleState threepuzzleState;
    [SerializeField] fourPuzzleState fourpuzzleState;

    GameObject playerMain;

    private void Start()
    {
        playerMain = GameObject.Find("PlayerMain");

        zeropuzzleState = playerMain.transform.Find("ZeroPuzzleState(Clone)").GetComponent<zeroPuzzleState>();
        onepuzzleState = playerMain.transform.Find("OnePuzzleState(Clone)").GetComponent<onePuzzleState>();
        twopuzzleState = playerMain.transform.Find("TwoPuzzleState(Clone)").GetComponent<twoPuzzleState>();
        threepuzzleState = playerMain.transform.Find("ThreePuzzleState(Clone)").GetComponent<threePuzzleState>();
        fourpuzzleState = playerMain.transform.Find("FourPuzzleState(Clone)").GetComponent<fourPuzzleState>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadSceneAsync("Scene2", LoadSceneMode.Single);

            PuzzleIsDone();
        }
    }

    public void PuzzleIsDone()
    {
        //Has to be done from the last puzzle state to the first

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
