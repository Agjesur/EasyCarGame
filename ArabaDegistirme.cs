using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject[] arabalar; // Sahnedeki tüm araba GameObjectlerini tutacak dizi
    public Dropdown dropdown;

    void Start()
    {
        // Sahnedeki tüm araba GameObjectlerini bulup diziye atýyoruz
        arabalar = GameObject.FindGameObjectsWithTag("Araba");

        // Dropdown menüsüne seçenekleri ekliyoruz
        dropdown.ClearOptions();
        foreach (var araba in arabalar)
        {
            dropdown.options.Add(new Dropdown.OptionData(araba.name));
        }

        // Dropdown menüsüne bir deðer seçildiðinde çaðrýlacak fonksiyonu atýyoruz
        dropdown.onValueChanged.AddListener(delegate { ArabaDegistir(dropdown.value); });
    }

    void ArabaDegistir(int index)
    {
        // Seçilen arabanýn index'ine göre diðer arabalarý etkisiz hale getiriyoruz
        for (int i = 0; i < arabalar.Length; i++)
        {
            arabalar[i].SetActive(i == index);
        }
    }
}