using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Sample_NavMeshAgent_Type2 : MonoBehaviour
{
    //public Transform Target;
    NavMeshAgent Agent;
    float observationRange = 50.0f;
    
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Debug.DrawRay(transform.position + Vector3.up * 1.5f, transform.forward * observationRange, Color.red);

        RaycastHit hitInfo;
        if(Physics.Raycast(transform.position + Vector3.up * 1.5f, transform.forward, out hitInfo, observationRange))
        {
            print(hitInfo.transform.name);
            if(hitInfo.transform.name == "FPSController")
            {
                print("Detected FPSController");
                Agent.destination = hitInfo.transform.position;
            }
            else
            {
                float randomDir = Random.Range(0, 360);
                transform.rotation = Quaternion.Euler(0, randomDir, 0);
            }
        }
        else
        {
            float randomDir = Random.Range(0, 360);
            transform.rotation = Quaternion.Euler(0, randomDir, 0);
        }
    }
}
