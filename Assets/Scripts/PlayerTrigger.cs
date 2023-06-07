using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") || Input.GetKeyDown("Space"))
        {
            Debug.Log("Player entered enemy trigger");
        }
    }
}