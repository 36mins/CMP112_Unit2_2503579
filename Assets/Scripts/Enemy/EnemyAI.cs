using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public GameObject player;
    public Transform playerpos;
    public NavMeshAgent enemy;
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        enemy.destination = GameObject.Find("player").transform.position;
        playerpos.position = GameObject.Find("player").transform.position;
    }
    void Update()
    {
        if (enemy.destination != playerpos.position)
        {
            enemy.SetDestination(playerpos.position);
        }

    }
}
