using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] arabalar; // Sahnedeki t�m araba GameObjectlerini tutacak dizi
    public Dropdown dropdown;

    void Start()
    {
        // Sahnedeki t�m araba GameObjectlerini bulup diziye at�yoruz
        arabalar = GameObject.FindGameObjectsWithTag("Araba");

        // Dropdown men�s�ne se�enekleri ekliyoruz
        dropdown.ClearOptions();
        foreach (var araba in arabalar)
        {
            dropdown.options.Add(new Dropdown.OptionData(araba.name));
        }

        // Dropdown men�s�ne bir de�er se�ildi�inde �a�r�lacak fonksiyonu at�yoruz
        dropdown.onValueChanged.AddListener(delegate { ArabaDegistir(dropdown.value); });
    }

    void ArabaDegistir(int index)
    {
        // Se�ilen araban�n index'ine g�re di�er arabalar� etkisiz hale getiriyoruz
        for (int i = 0; i < arabalar.Length; i++)
        {
            arabalar[i].SetActive(i == index);
        }
    }
}