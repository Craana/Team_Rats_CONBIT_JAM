using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IfInPuzzle2 : MonoBehaviour
{
    [SerializeField] string currentScene;

    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "Puzzle1" || currentScene == "Puzzle2" || currentScene == "Puzzle3" || currentScene == "Puzzle4" || currentScene == "Puzzle5") 
        {
            transform.GetComponent<SpriteRenderer>().enabled = false;
        }
        else 
        {
            transform.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
