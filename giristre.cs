using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class giristre : MonoBehaviour
{
    void Start()
    {
        // Oyun ba�lad���nda giri� ekran�na ge�i� yap
        SceneManager.LoadScene("giris");
    }
}
