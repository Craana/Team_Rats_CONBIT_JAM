using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainToken : MonoBehaviour
{
    GameObject TokenContro;
    SpriteRenderer spriteRenderer;
    public Sprite[] faces;
    public Sprite back;
    public int faceIndex;
    public bool matched = false;

    private void Awake()
    {
        TokenContro = GameObject.Find("GameControl");
        spriteRenderer = GetComponent<SpriteRenderer>();
    
    }

    public void OnMouseDown()
    {
        if (matched == false)
        {
            if (spriteRenderer.sprite == back)
            {
                if (TokenContro.GetComponent<TokenContro>().TwoCardsUp() == false)
                {
                    spriteRenderer.sprite = faces[faceIndex];
                    TokenContro.GetComponent<TokenContro>().AddVisibleFace(faceIndex);
                    matched = TokenContro.GetComponent<TokenContro>().CheckMatch();
                }
            }
            else
            {
                spriteRenderer.sprite = back;
                TokenContro.GetComponent<TokenContro>().RemoveVisibleFace(faceIndex);
            }
        }
    }

}