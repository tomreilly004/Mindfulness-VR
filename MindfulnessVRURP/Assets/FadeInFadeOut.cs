using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class FadeInFadeOut : MonoBehaviour
{
    [SerializeField] private CanvasGroup[] canvasGroups;

    [SerializeField] private bool fadeIn = false;
    [SerializeField] private bool fadeOut = false;

    public int i = 0;
    public void ShowUI()
    {
        fadeIn = true;
    }    
    public void HideUI()
    {
        fadeOut = true;
    }
    void Update()
    {
        if(i == 5)
        {
            i = 0;
        }
        if(fadeIn) 
        {
            if (canvasGroups[i].alpha < 1)
            {
                canvasGroups[i].alpha += Time.deltaTime/2;
                if (canvasGroups[i].alpha >= 1)
                {
                    fadeIn = false;
                    fadeOut = true;
                }
            }
        }        
        if(fadeOut) 
        {
            if (canvasGroups[i].alpha >= 0)
            {
                
                if (i == 1) 
                { 
                    canvasGroups[i].alpha -= Time.deltaTime / 4; 
                } 
                else 
                { 
                    canvasGroups[i].alpha -= Time.deltaTime / 3; 
                }
                if (canvasGroups[i].alpha == 0)
                {
                    fadeOut = false;
                    i++;
                }
            }
        }
    }
}
