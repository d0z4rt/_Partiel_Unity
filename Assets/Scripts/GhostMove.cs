using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostMove : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    private NavMeshAgent agent;

    void OnGameStart()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(player.position);
    }
}
