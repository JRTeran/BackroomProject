using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasarNivel : MonoBehaviour
{
    public int totalObjetosRecolectados;
    private string mensaje;
    public Recolector recolector;
    void Start()
    {
        totalObjetosRecolectados = 0;
        mensaje = "";
    }

    void Update()
    {
        totalObjetosRecolectados = Recolector.totalVHSRecolectados;
        if (totalObjetosRecolectados >= 5)
        {
            if (Input.GetButtonDown("Submit"))
            {
                SceneManager.LoadScene("Creditos");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            int objetosFaltantes = 5 - Recolector.totalVHSRecolectados;
            if (objetosFaltantes == 1)
            {
                mensaje = "Te falta 1 VHS para abrir la puerta";
            }
            if (objetosFaltantes == 0)
            {
                mensaje = "TIenes los VHS !!ESCAPA¡¡";
            }
            else
            {
                mensaje = "Te faltan " + objetosFaltantes + " VHS para abrir la puerta";
            }
            totalObjetosRecolectados = Recolector.totalVHSRecolectados;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            mensaje = "";
        }
    }

    void OnGUI()
    {
        GUIStyle style = new GUIStyle(GUI.skin.label);
        style.fontSize = 25;
        if (!string.IsNullOrEmpty(mensaje))
        {
            // Mostrar mensaje en la cámara izquierda
            GUI.Label(new Rect(Screen.width / 4 - 50, Screen.height / 2 - 25, 200, 50), mensaje);

            // Mostrar mensaje en la cámara derecha
            GUI.Label(new Rect(Screen.width * 3 / 4 - 50, Screen.height / 2 - 25, 200, 50), mensaje);
        }
    }
}
