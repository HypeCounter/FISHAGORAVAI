using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Character : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
  //  [SerializeField]Transform destination;

    private void Start()
    {

        navMeshAgent = GetComponent<NavMeshAgent>();

       


    }
    public void MoveTo(Vector3 destination)
    {
        GetComponent<NavMeshAgent>().destination = destination;
        
    }
}
