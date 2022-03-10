using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleFiveHazard : MonoBehaviour
{

    [SerializeField] float restartTime;
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
        SceneManager.LoadScene("Puzzle5");
    }

}
