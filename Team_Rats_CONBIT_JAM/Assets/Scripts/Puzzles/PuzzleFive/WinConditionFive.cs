using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinConditionFive : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Add code to here to give enable piece on the scene and disable this scene.
        Debug.Log("You win!");
    }
}
