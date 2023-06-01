using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Perseguidor : MonoBehaviour
{
    public Transform objetivo;
    private NavMeshAgent agente;
    private void Awake()
    {
        agente = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agente.SetDestination(objetivo.position);
    }
}
