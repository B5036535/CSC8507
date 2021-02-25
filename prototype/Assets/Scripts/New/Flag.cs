using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Flag : MonoBehaviour
{

    [SerializeField]Observer obs;


    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player"))
        {
            obs.EndGame();
        }
    }
}
