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
        navMeshAgent.destination = movePosTrans.position;
    }

    void OnTriggerStay(Collider other) {
        if(other.gameObject.tag == "Player") {
            anim.Play("attack");
        }
    }
}
