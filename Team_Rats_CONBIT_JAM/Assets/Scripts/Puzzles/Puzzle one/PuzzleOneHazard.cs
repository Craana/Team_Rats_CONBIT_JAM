using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleOneHazard : MonoBehaviour
{

    [SerializeField] float restartTime;
    [SerializeField] GameObject Player;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            StartCoroutine(WaitLoadScene());
        }
    }


    IEnumerator WaitLoadScene()
    {
        yield return new WaitForSeconds(restartTime);
        SceneManager.LoadScene("Puzzle1");
    }

}