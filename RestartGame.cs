using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour
{
    // Butona ba�l� olarak �al��acak fonksiyon
    public void Restart()
    {
        
        string anaekran = "anaekran"; 
        SceneManager.LoadScene(anaekran);
    }
}