using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    public KeyCode kickKey = KeyCode.Space;
    public Animator animator;



    [SerializeField] private NavMeshAgent agent;
    //pobieramy pozycje obiektu do którego chcemy dotrzeæ
    //[SerializeField] private Transform target;
    [SerializeField] private Animator anim;

    private Vector2 Velocity;
    void Start()
    {
        //agent.SetDestination(target.position);
       // Move(target.position);
    }

    private void Update()
    {
        Vector3 velocity = agent.velocity;
        Vector3 localVelocity = transform.InverseTransformDirection(velocity);
        float speed = localVelocity.z;
        anim.SetFloat("velocity", speed);

        if (Input.GetKeyDown(kickKey))
        {
            Kick();
        }

    }

    public void Move(Vector3 position)
    {
        agent.SetDestination(position);
    }

    private void Kick()
    {
        // Uruchamianie animacji kopniêcia
        animator.SetTrigger("kick");
    }

}
