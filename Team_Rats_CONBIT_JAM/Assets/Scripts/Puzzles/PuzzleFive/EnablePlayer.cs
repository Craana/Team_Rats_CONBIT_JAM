using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePlayer : MonoBehaviour
{
    [SerializeField] GameObject Player;

    public void ActivatePlayer()
    {
        Player.gameObject.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
