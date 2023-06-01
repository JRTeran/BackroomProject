using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Creditos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("waitToEnd", 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void waitToEnd()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
