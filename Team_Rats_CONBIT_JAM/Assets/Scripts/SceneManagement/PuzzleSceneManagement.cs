using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleSceneManagement : MonoBehaviour
{
    [SerializeField] string loadSceneName;

    GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerMain"))
        {
            SceneManager.LoadSceneAsync(loadSceneName, LoadSceneMode.Single);

            this.gameObject.SetActive(false);
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
