using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    public bool isChasing = false;

    Transform player;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (isChasing)
            agent.SetDestination(player.position);
    }
}
