using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleSceneManagement : MonoBehaviour
{
    [SerializeField] string loadSceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerMain"))
        {
            SceneManager.LoadSceneAsync(loadSceneName, LoadSceneMode.Single);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerMain"))
        {
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
        }
    }
}
