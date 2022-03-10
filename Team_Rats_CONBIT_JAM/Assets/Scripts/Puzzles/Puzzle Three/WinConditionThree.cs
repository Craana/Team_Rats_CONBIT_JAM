using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditionThree : MonoBehaviour
{
    [SerializeField] int PiecesInTheRightSpots;

    private void Update()
    {
        if (PiecesInTheRightSpots == 4)
        {
            //Trigger an win.
            Debug.Log("WE HAVE WINNER");
        }
    }
    
    public void AddScore()
    {
        PiecesInTheRightSpots ++;
    }

}
