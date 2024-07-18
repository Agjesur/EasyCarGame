using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private bool soundOn = true; // Sesin açýk veya kapalý olduðunu takip eden deðiþken

    // Butona baðlý olarak çalýþacak fonksiyon
    public void ToggleSound()
    {
        soundOn = !soundOn; // Ses durumunu tersine çevir

        if (soundOn)
        {
            AudioListener.volume = 1f; // Sesin ses düzeyini 1'e (tam ses) ayarla
        }
        else
        {
            AudioListener.volume = 0f; // Sesin ses düzeyini 0'a (ses kapalý) ayarla
        }
    }
}