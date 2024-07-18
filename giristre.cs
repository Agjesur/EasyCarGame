using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class giristre : MonoBehaviour
{
    void Start()
    {
        // Oyun baþladýðýnda giriþ ekranýna geçiþ yap
        SceneManager.LoadScene("giris");
    }
}
