using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // Butona ba�l� olarak �al��acak fonksiyon
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("anaekran"); // anaekran adl� sahneye ge�i� yap
    }
}
