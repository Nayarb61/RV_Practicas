using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro_Imagenes : MonoBehaviour
{
    public Transform cameraTransform; // La transformaci�n de la c�mara.
    public float rotationSpeed = 20.0f;
    public bool isRotating = true;

    void Update()
    {
        if (isRotating)
        {
            // Obt�n la posici�n de la c�mara como centro de rotaci�n.
            Vector3 cameraPosition = cameraTransform.position;

            // Rotar el objeto alrededor de la posici�n de la c�mara.
            transform.RotateAround(cameraPosition, Vector3.up, rotationSpeed * Time.deltaTime);
        }

    }
}
