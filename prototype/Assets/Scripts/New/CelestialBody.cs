using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelestialBody : GravityProducer
{
    public Transform pivot;

    public float rotateSpeed = 0f;
    public float distance = 10f;


    private void Awake() {
        gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }

    void FixedUpdate()
    {
        if(pivot != null)
        {
            transform.position = pivot.position + (transform.position - pivot.position).normalized * distance;
            transform.RotateAround(pivot.position, Vector3.up, rotateSpeed * Time.fixedDeltaTime);
        }

    }
}
