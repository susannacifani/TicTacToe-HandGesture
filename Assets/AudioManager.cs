using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class AudioManager : MonoBehaviour
{

    public AudioSource musicSource; // Riferimento all'AudioSource della musica di background
    public AudioSource[] sfxSources; // Array di AudioSource per gli effetti speciali
    public Slider musicSlider; // Riferimento allo slider per il controllo del volume della musica
    public Slider sfxSlider; // Riferimento allo slider per il controllo del volume degli effetti speciali

    void Start()
    {
        // Imposta il valore iniziale degli slider
        musicSlider.value = musicSource.volume;
        sfxSlider.value = sfxSources[0].volume; // Supponiamo che tutti gli effetti speciali abbiano lo stesso volume iniziale
    }

    public void ChangeMusicVolume()
    {
        musicSource.volume = musicSlider.value;
    }

    public void ChangeSFXVolume()
    {
        foreach (AudioSource sfxSource in sfxSources)
        {
            sfxSource.volume = sfxSlider.value;
        }
    }



}
