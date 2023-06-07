using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControlller : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public Transform player;
    public float movementSpeed = 1f;
    public float avoidRadius = 5f;
    public float stopDistance = 10f;

    private void Update()
    {
       float distance = Vector3.Distance(player.position, transform.position);
       
        Debug.Log("Odleglosc to: " + distance);
        if (distance < stopDistance)
        {
            MoveAwayFromPlayer();
            RotateTowardsMovementDirection();
            anim.SetTrigger("walk");
            //  AvoidObstacles();
        }
        else
        {
            anim.SetTrigger("idle");
        }
        
    }

    private void MoveAwayFromPlayer()
    {
        Vector3 direction = transform.position - player.position;
        Vector3 targetPosition = transform.position + direction.normalized * movementSpeed * Time.deltaTime;
        transform.position = targetPosition;
    }

    private void RotateTowardsMovementDirection()
    {
        Vector3 movementDirection = transform.position - player.position;
        Quaternion targetRotation = Quaternion.LookRotation(movementDirection);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 1f);
    }
    private void AvoidObstacles()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, avoidRadius);

        foreach (Collider collider in hitColliders)
        {
            if (collider.gameObject != gameObject)
            {
                Vector3 avoidDirection = transform.position - collider.transform.position;
                transform.position += avoidDirection.normalized * Time.deltaTime;
            }
        }
    }
}
