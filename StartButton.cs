using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    // Butona baðlý olarak çalýþacak fonksiyon
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("anaekran"); // anaekran adlý sahneye geçiþ yap
    }
}
