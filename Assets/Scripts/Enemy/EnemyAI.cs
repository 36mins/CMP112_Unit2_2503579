using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private Transform player;       //gets the players location
    private NavMeshAgent enemy;         //uses Navmesh to naviagte the scene

    void Awake()
    {
        enemy = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player").transform;   //find any objects taged "Player"
    }

    void Update()
    {
        enemy.SetDestination(player.position); //the enemy starts going to the player
    }
}
