using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class PuzzleOneHazard : MonoBehaviour
{

    [SerializeField] float restartTime;
    [SerializeField] GameObject player;
    [SerializeField] AudioSource fail;
    [SerializeField] PlayableDirector failDirector;

    private void Start()
    {
        player = GameObject.Find("Player");
        failDirector = GameObject.Find("FailZoom").GetComponent<PlayableDirector>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().simulated = false;

            failDirector.Play();

            fail = collision.gameObject.GetComponent<AudioSource>();

            fail.Play();

            StartCoroutine(WaitLoadScene());        
        }
    }


    IEnumerator WaitLoadScene()
    {
        yield return new WaitForSeconds(restartTime);

        Destroy(player);

        SceneManager.LoadScene("Puzzle1");
    }

}
