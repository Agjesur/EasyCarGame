using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
    public float speed = 10f; // Araban�n hareket h�z�
    public float rotationSpeed = 100f; // Araban�n d�n�� h�z�

    void Update()
    {
        // Klavyeden giri� al
        float horizontalInput = SimpleInput.GetAxis("Horizontal");
        float verticalInput = SimpleInput.GetAxis("Vertical");

        // Araban�n ileri-geri hareketi
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

        // Araban�n d�n���
        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
