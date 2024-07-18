using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DayNightCycle : MonoBehaviour
{ 

    public float cycleDuration = 60f; // Bir d�ng� s�resi (saniye cinsinden)
    public Light sunLight; // G�ne� veya ay ����� �����
    public Color dayColor;
    public Color nightColor;

    private float currentCycleTime = 0f;
    private bool isDay = true;

    void Start()
    {
        // Ba�lang��ta gece-g�nd�z d�ng�s�n� ba�latmak i�in InvokeRepeating kullanarak 30 saniyede bir UpdateColors fonksiyonunu �a��r�yoruz.
        InvokeRepeating("UpdateColors", 0f, 30f);
    }

    void UpdateColors()
    {
        // Gece-g�nd�z ge�i�ini yap
        isDay = !isDay;

        // E�er g�nd�zse, g�nd�z rengine, geceyse gece rengine ge�i� yap
        if (isDay)
        {
            sunLight.color = dayColor;
        }
        else
        {
            sunLight.color = nightColor;
        }
    }

    void Update()
    {
        // Zaman� g�ncelle
        currentCycleTime += Time.deltaTime;

        // Renkleri zamanla de�i�tir
        if (isDay)
        {
            float t = currentCycleTime / cycleDuration;
            sunLight.color = Color.Lerp(nightColor, dayColor, t);
        }
        else
        {
            float t = currentCycleTime / cycleDuration;
            sunLight.color = Color.Lerp(dayColor, nightColor, t);
        }

        // D�ng� s�resi a��ld���nda, d�ng�y� s�f�rla
        if (currentCycleTime > cycleDuration)
        {
            currentCycleTime = 0f;
        }
    }
}
