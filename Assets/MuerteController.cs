using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MuerteController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("waitToEnd", 07);
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
