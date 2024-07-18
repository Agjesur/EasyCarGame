using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
    public float speed = 10f; // Arabanýn hareket hýzý
    public float rotationSpeed = 100f; // Arabanýn dönüþ hýzý

    void Update()
    {
        // Klavyeden giriþ al
        float horizontalInput = SimpleInput.GetAxis("Horizontal");
        float verticalInput = SimpleInput.GetAxis("Vertical");

        // Arabanýn ileri-geri hareketi
        transform.Translate(Vector3.forward * verticalInput * speed * Time.deltaTime);

        // Arabanýn dönüþü
        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
