using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasSwitcher : MonoBehaviour
{
    [SerializeField]GameObject CodePanelCanvas;
    [SerializeField]GameObject ImageCanvas;

    bool switcheroo = false;

    void Update()
    {
        if (switcheroo == false)
        {
            CodePanelCanvas.gameObject.SetActive(true);
            ImageCanvas.gameObject.SetActive(false);
        }
        if (switcheroo == true)
        {
            CodePanelCanvas.gameObject.SetActive(false);
            ImageCanvas.gameObject.SetActive(true);
        }
    }

    public void ChangeCanvases()
    {
        switcheroo = !switcheroo;
    }

}
