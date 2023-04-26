using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopActivity : MonoBehaviour
{
    public GameObject painting;
    public GameObject fiveSenses;
    public GameObject bodyScan;
    public GameObject musicListening;
    public GameObject dancingShaking;

    public GameObject paintHandMenu;
    public GameObject sensesHandMenu;
    public GameObject bodyHandMenu;
    public GameObject musicHandMenu;
    public GameObject dancingHandMenu;

    public void StopCurrentActivity()
    {
        paintHandMenu.SetActive(false);
        sensesHandMenu.SetActive(false);
        bodyHandMenu.SetActive(false);
        musicHandMenu.SetActive(true);
        dancingHandMenu.SetActive(false);

        painting.SetActive(false);
        fiveSenses.SetActive(false);
        bodyScan.SetActive(false);
        dancingShaking.SetActive(false);
        musicListening.SetActive(false);
    }
}
