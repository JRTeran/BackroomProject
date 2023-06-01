using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screamer : MonoBehaviour
{
    public GameObject Screameer;
    public GameObject SonidoScreamer;

    //Se activan cuando el jugador colisona
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Screameer.SetActive(true);
            SonidoScreamer.SetActive(true);
        }
    }

    //Se desactivan cuando el jugador colisona
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Screameer.SetActive(false);
            SonidoScreamer.SetActive(false);

            //Se destruye el objeto para que no se duplique
            Destroy(this);
        }


    }
}
