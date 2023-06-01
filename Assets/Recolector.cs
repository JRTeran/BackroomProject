using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recolector : MonoBehaviour
{
    bool ingreso = false;
    private string message = "Recoge el VHS";
    public static int totalVHSRecolectados = 0;

    public Text totalVHSText; // referencia al objeto Text

    void Start()
    {
        PlayerPrefs.DeleteAll();
        totalVHSRecolectados = PlayerPrefs.GetInt("VHS");
        if (totalVHSRecolectados == 0) // Si no hay ningún valor guardado en PlayerPrefs, se asigna 0 al contador
        {
            totalVHSRecolectados = 0;
            PlayerPrefs.SetInt("VHS", totalVHSRecolectados);
        }
        UpdateTotalVHSText(); // actualizar el texto inicialmente
    }

    void Update()
    {
        if (ingreso && (Input.GetButtonDown("Submit") || Input.GetButtonDown("Fire1")))
        {
            totalVHSRecolectados += 1;
            Destroy(gameObject);
            GetComponent<Collider>().enabled = false;
            UpdateTotalVHSText(); // actualizar el texto cada vez que se recolecta un VHS
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ingreso = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ingreso = false;
        }
    }

    void OnGUI()
    {
        if (ingreso)
        {
            GUIStyle style = new GUIStyle(GUI.skin.label);
            style.fontSize = 25;
            // Mostrar mensaje en la cámara izquierda
            GUI.Label(new Rect(Screen.width / 4 - 50, Screen.height / 2 - 25, 200, 50), message, style);

            // Mostrar mensaje en la cámara derecha
            GUI.Label(new Rect(Screen.width * 3 / 4 - 50, Screen.height / 2 - 25, 200, 50), message, style);
        }
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("VHS", totalVHSRecolectados);
    }

    void UpdateTotalVHSText()
    {
        totalVHSText.text = "VHS recolectados: " + totalVHSRecolectados; // actualizar el contenido del objeto Text
    }
}
