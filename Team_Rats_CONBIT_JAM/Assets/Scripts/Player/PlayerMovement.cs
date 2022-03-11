using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float movementSpeed;
    [SerializeField] float xMove;
    [SerializeField] float yMove;
    [SerializeField] Animator playerAnim;
    [SerializeField] SpriteRenderer playerRender;
    [SerializeField] GameObject playerSprite;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSprite = GameObject.Find("PlayerSprite");
        playerAnim = playerSprite.GetComponent<Animator>();
        playerRender = playerSprite.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        yMove = Input.GetAxis("Vertical");
        xMove = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(xMove, yMove);

        if (movement.x <= 1 && movement.x > 0 || movement.y <= 1 && movement.y > 0 || movement.x >= -1 && movement.x < 0 || movement.y >= -1 && movement.y < 0) 
        {
            playerAnim.SetBool("isWalking", true);
        }
        else 
        {
            playerAnim.SetBool("isWalking", false);
        }

        if (movement.y <= 1 && movement.y > 0) 
        {
            playerRender.flipY = true;
        }
        else if (movement.y >= -1 && movement.y < 0) 
        {
            playerRender.flipY = false;
        }


        if (playerRender.flipY == false) 
        {
            if (movement.x == 1 && movement.y >= 0) 
            {
                Quaternion rotation = Quaternion.Euler(0, 0, 90);

                playerSprite.transform.rotation = rotation;
            }
            else if (movement.x == 1 && movement.y  <= 0)
            {
                Quaternion rotation = Quaternion.Euler(0, 0, 90);

                playerSprite.transform.rotation = rotation;
            }

            if (movement.x == -1 && movement.y <= 0) 
            {
                Quaternion rotation = Quaternion.Euler(0, 0, -90);

                playerSprite.transform.rotation = rotation;
            }
            else if (movement.x == -1 && movement.y >= 0) 
            {
                Quaternion rotation = Quaternion.Euler(0, 0, -90);

                playerSprite.transform.rotation = rotation;
            }
        }


        if (playerRender.flipY == true)
        {
            if (movement.x == 1 && movement.y >= 0)
            {
                Quaternion rotation = Quaternion.Euler(0, 0, -90);

                playerSprite.transform.rotation = rotation;
            }
            else if (movement.x == 1 && movement.y <= 0)
            {
                Quaternion rotation = Quaternion.Euler(0, 0, -90);

                playerSprite.transform.rotation = rotation;
            }

            if (movement.x == -1 && movement.y <= 0)
            {
                Quaternion rotation = Quaternion.Euler(0, 0, 90);

                playerSprite.transform.rotation = rotation;
            }
            else if (movement.x == -1 && movement.y >= 0)
            {
                Quaternion rotation = Quaternion.Euler(0, 0, 90);

                playerSprite.transform.rotation = rotation;
            }
        }

        if (movement.x < 1 && movement.x > -1) 
        {
            Quaternion rotation = Quaternion.Euler(0, 0, 0);

            playerSprite.transform.rotation = rotation;
        }

        //Switched back to rb.addforce as rb.moveposition is meant for kinematinc rb's

        rb.AddForce(movement * movementSpeed * Time.deltaTime);
    }
}
