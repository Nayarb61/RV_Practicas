using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio_Carruse : MonoBehaviour
{
    public Camera[] cameras; //Arreglo de camaras
    private int currentCameraIndex = 0; // Índice de la cámara actual.

    public float timerEspera = 100.0f; // Tiempo entre cambios de cámara en segundos.
    private float reinicioContador = 0.0f;

    void Start()
    {
        // Inicialmente, activa la primera cámara y desactiva las demás.
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].enabled = (i == 0);
        }
    }

    void Update()
    {
        // Comprobar si es hora de cambiar de cámara.
        reinicioContador += Time.deltaTime;
        if (reinicioContador >= timerEspera)
        {
            CambioCamara();
            reinicioContador = 0.0f; // Reiniciar el contador de tiempo.
        }
    }

    void CambioCamara()
    {
        cameras[currentCameraIndex].enabled = false; // Desactivar la cámara actual.

        currentCameraIndex++;
        if (currentCameraIndex >= cameras.Length)
        {
            currentCameraIndex = 0; // Volver al inicio si llegamos al final.
        }

        cameras[currentCameraIndex].enabled = true; // Activar la próxima cámara.
    }
}


