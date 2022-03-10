using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleOneMover : MonoBehaviour
{
    [SerializeField] float speed;
    bool canMove = false;
   [SerializeField] Rigidbody2D rb;

    float xMove;
    float yMove;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal");
        yMove = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(xMove, yMove);

        if (canMove == true)
        {
            rb.AddForce(movement * speed * Time.deltaTime, ForceMode2D.Impulse);  
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            canMove = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        canMove = false;
    }
}
