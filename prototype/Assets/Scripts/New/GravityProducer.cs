using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityProducer : MonoBehaviour
{

    [Min(1)]
    public float scale;
    [Min(1)]
    public float mass;
    
    protected void OnValidate() 
    {
        gameObject.transform.localScale = Vector3.one * scale;
    }

    protected void Start() 
    {
        gameObject.transform.localScale = Vector3.one * scale;
    }



    protected void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<GravityReceiver>().floating = false;
        }
    }
}
