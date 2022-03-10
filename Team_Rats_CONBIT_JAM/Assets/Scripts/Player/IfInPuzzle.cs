using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IfInPuzzle : MonoBehaviour
{
    [SerializeField] string currentScene;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "Puzzle1" || currentScene == "Puzzle2" || currentScene == "Puzzle3" || currentScene == "Puzzle4" || currentScene == "Puzzle5") 
        {
            gameObject.transform.Find("Cameras").gameObject.SetActive(false);

            transform.GetComponent<Rigidbody2D>().simulated = false;

            transform.GetComponent<SpriteRenderer>().enabled = false;
        }
        else 
        {
            gameObject.transform.Find("Cameras").gameObject.SetActive(true);

            transform.GetComponent<Rigidbody2D>().simulated = true;

            transform.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
