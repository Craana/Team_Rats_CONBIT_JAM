using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditionTwo : MonoBehaviour
{
    [SerializeField] TokenContro tokenContro;
    

    // Start is called before the first frame update
    void Start()
    {
        tokenContro = GetComponent<TokenContro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (tokenContro.amountOfMatches == 3)
        {
            //Trigger a wincondition!
            Debug.Log("WIN WIN WIN");
        }
    }
}
