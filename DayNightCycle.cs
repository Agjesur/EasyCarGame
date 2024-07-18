using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DayNightCycle : MonoBehaviour
{ 

    public float cycleDuration = 60f; // Bir döngü süresi (saniye cinsinden)
    public Light sunLight; // Güneþ veya ay ýþýðý ýþýðý
    public Color dayColor;
    public Color nightColor;

    private float currentCycleTime = 0f;
    private bool isDay = true;

    void Start()
    {
        // Baþlangýçta gece-gündüz döngüsünü baþlatmak için InvokeRepeating kullanarak 30 saniyede bir UpdateColors fonksiyonunu çaðýrýyoruz.
        InvokeRepeating("UpdateColors", 0f, 30f);
    }

    void UpdateColors()
    {
        // Gece-gündüz geçiþini yap
        isDay = !isDay;

        // Eðer gündüzse, gündüz rengine, geceyse gece rengine geçiþ yap
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
        // Zamaný güncelle
        currentCycleTime += Time.deltaTime;

        // Renkleri zamanla deðiþtir
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

        // Döngü süresi aþýldýðýnda, döngüyü sýfýrla
        if (currentCycleTime > cycleDuration)
        {
            currentCycleTime = 0f;
        }
    }
}
