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
    public AudioSource currentlyPlaying;
    
    public void PlayJapanese()
    {
        currentlyPlaying.Pause();
        currentlyPlaying = japaneseMusic.GetComponent<AudioSource>();
        currentlyPlaying.Play();
    }    
    public void PlayIndian()
    {
        currentlyPlaying.Pause();
        currentlyPlaying = indianMusic.GetComponent<AudioSource>();
        currentlyPlaying.Play();
    }    
    public void PlayHandpan()
    {
        currentlyPlaying.Pause();
        currentlyPlaying = handpanMusic.GetComponent<AudioSource>();
        currentlyPlaying.Play();
    }    
    public void PlaySolfeggio()
    {
        currentlyPlaying.Pause();
        currentlyPlaying = solfeggioMusic.GetComponent<AudioSource>();
        currentlyPlaying.Play();
    }    
    public void PlayBinaural()
    {
        currentlyPlaying.Pause();
        currentlyPlaying = binauralMusic.GetComponent<AudioSource>();
        currentlyPlaying.Play();
    }    
    public void PlayClassical()
    {
        currentlyPlaying.Pause();
        currentlyPlaying = classicalMusic.GetComponent<AudioSource>();
        currentlyPlaying.Play();
    }    
    public void PlayIsochronic()
    {
        currentlyPlaying.Pause();
        currentlyPlaying = isochronicMusic.GetComponent<AudioSource>();
        currentlyPlaying.Play();
    }    
    public void StopMusic()
    {
        currentlyPlaying.Pause();
    }
}
