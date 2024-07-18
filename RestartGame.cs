using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour
{
    // Butona baðlý olarak çalýþacak fonksiyon
    public void Restart()
    {
        
        string anaekran = "anaekran"; 
        SceneManager.LoadScene(anaekran);
    }
}