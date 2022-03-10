using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonHandler : MonoBehaviour
{
   [SerializeField] GameObject MainMenu;
   [SerializeField] GameObject Settings;

    bool settingsEnabled = false;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void settingsButton()
    {
        settingsEnabled = true;
    }
    public void BackToMenu()
    {
        settingsEnabled = false;
    }


    public void Quitgame()
    {
        Debug.Log("I will quit!");
        Application.Quit();
    }
    private void Update()
    {
        if (settingsEnabled == true)
        {
            MainMenu.gameObject.SetActive(false);
            Settings.gameObject.SetActive(true);
        }
        if (settingsEnabled == false)
        {
            MainMenu.gameObject.SetActive(true);
            Settings.gameObject.SetActive(false);
        }
    }
}
