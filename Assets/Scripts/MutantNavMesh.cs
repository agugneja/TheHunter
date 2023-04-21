using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MutantNavMesh : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Animator anim;
    [SerializeField] private Transform movePosTrans;

    private void Awake() {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Start() {
        anim = GetComponent<Animator>();
    }

    private void Update() {
        //mutant navmesh towards player
        navMeshAgent.destination = movePosTrans.position;
    }

    void OnTriggerStay(Collider other) {
        //attack animation on collision with player
        if(other.gameObject.tag == "Player") {
            anim.Play("attack");
        }
    }
}
