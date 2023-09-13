using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro_Imagenes : MonoBehaviour
{
    public Transform cameraTransform; // La transformación de la cámara.
    public float rotationSpeed = 20.0f;
    public bool isRotating = true;

    void Update()
    {
        if (isRotating)
        {
            // Obtén la posición de la cámara como centro de rotación.
            Vector3 cameraPosition = cameraTransform.position;

            // Rotar el objeto alrededor de la posición de la cámara.
            transform.RotateAround(cameraPosition, Vector3.up, rotationSpeed * Time.deltaTime);
        }

    }
}
