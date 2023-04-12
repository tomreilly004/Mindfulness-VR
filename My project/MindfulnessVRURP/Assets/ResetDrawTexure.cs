using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ResetDrawTexure : MonoBehaviour
{
    public RenderTexture DrawTexture; 
    public void OnButtonPress()
    {
        print("hello");
        DrawTexture.Release(); 
    }
}

