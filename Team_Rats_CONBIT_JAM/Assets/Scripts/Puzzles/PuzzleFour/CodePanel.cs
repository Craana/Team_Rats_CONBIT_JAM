using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour
{
    [SerializeField] Text codeText;
    string codeTextValue = "";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;
        if (codeTextValue == "1234")
        {
            //Add piece of peace letter to the character and exit from this scene.
            Debug.Log("You win!");
        }
        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}
