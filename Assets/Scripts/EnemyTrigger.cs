using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] private Animator anim;
    public float speed = 1f;
    private Rigidbody enemyRigidbody;
    private EnemyControlller enemyControlllerScript;

    private void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
        enemyControlllerScript = GetComponent<EnemyControlller>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown("space"))
        {  Debug.Log("Player entered enemy trigger");
            
            if(Input.GetKeyDown("space"))
            {  Debug.Log("Kick");

                anim.SetTrigger("afterKick");
                FreezePosition();
                MoveDown();
                Destroy(gameObject, 5.0f);
                }


        }
    }
    private void FreezePosition()
    {
        enemyControlllerScript.enabled= false;
    }

    private void MoveDown()
    {
        return;
    }
}
