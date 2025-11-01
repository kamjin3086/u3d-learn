using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{

    public Transform player;
    private NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        //set random position
        transform.position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
    }

    // Update is called once per frame
    void Update()
    {
        if(player!=null){
            navMeshAgent.SetDestination(player.position);
        }
    }
}
