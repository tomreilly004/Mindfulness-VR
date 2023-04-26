using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public GameObject japaneseMusic;
    public GameObject indianMusic;
    public GameObject handpanMusic;
    public GameObject solfeggioMusic;
    public GameObject binauralMusic;
    public GameObject classicalMusic;
    public GameObject isochronicMusic; 
    
    public void PlayJapanese()
    {
        japaneseMusic.SetActive(true);
        indianMusic.SetActive(false);
        handpanMusic.SetActive(false);
        solfeggioMusic.SetActive(false);
        binauralMusic.SetActive(false);
        classicalMusic.SetActive(false);
        isochronicMusic.SetActive(false);
    }    
    public void PlayIndian()
    {
        japaneseMusic.SetActive(false);
        indianMusic.SetActive(true);
        handpanMusic.SetActive(false);
        solfeggioMusic.SetActive(false);
        binauralMusic.SetActive(false);
        classicalMusic.SetActive(false);
        isochronicMusic.SetActive(false);
    }    
    public void PlayHandpan()
    {
        japaneseMusic.SetActive(false);
        indianMusic.SetActive(false);
        handpanMusic.SetActive(true);
        solfeggioMusic.SetActive(false);
        binauralMusic.SetActive(false);
        classicalMusic.SetActive(false);
        isochronicMusic.SetActive(false);
    }    
    public void PlaySolfeggio()
    {
        japaneseMusic.SetActive(false);
        indianMusic.SetActive(false);
        handpanMusic.SetActive(false);
        solfeggioMusic.SetActive(true);
        binauralMusic.SetActive(false);
        classicalMusic.SetActive(false);
        isochronicMusic.SetActive(false);
    }    
    public void PlayBinaural()
    {
        japaneseMusic.SetActive(false);
        indianMusic.SetActive(false);
        handpanMusic.SetActive(false);
        solfeggioMusic.SetActive(false);
        binauralMusic.SetActive(true);
        classicalMusic.SetActive(false);
        isochronicMusic.SetActive(false);
    }    
    public void PlayClassical()
    {
        japaneseMusic.SetActive(false);
        indianMusic.SetActive(false);
        handpanMusic.SetActive(false);
        solfeggioMusic.SetActive(false);
        binauralMusic.SetActive(false);
        classicalMusic.SetActive(true);
        isochronicMusic.SetActive(false);
    }    
    public void PlayIsochronic()
    {
        japaneseMusic.SetActive(false);
        indianMusic.SetActive(false);
        handpanMusic.SetActive(false);
        solfeggioMusic.SetActive(false);
        binauralMusic.SetActive(false);
        classicalMusic.SetActive(false);
        isochronicMusic.SetActive(true);
    }    
    public void StopMusic()
    {
        japaneseMusic.SetActive(false);
        indianMusic.SetActive(false);
        handpanMusic.SetActive(false);
        solfeggioMusic.SetActive(false);
        binauralMusic.SetActive(false);
        classicalMusic.SetActive(false);
        isochronicMusic.SetActive(false);
    }
}
