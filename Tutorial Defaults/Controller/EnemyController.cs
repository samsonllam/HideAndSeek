﻿using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent agent;
    
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
