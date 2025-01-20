using UnityEngine;
using UnityEngine.AI;

public class GhostMove : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(player.position);
    }
}
