using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityReceiver : MonoBehaviour
{

    public bool floating;

    const float G = 0.0001f;

    public List<GravityProducer> planets;
    public Rigidbody rbody;

    [SerializeField] GravityProducer bestPlanet;
    Vector3 gravityForce;
    public Vector3 bestDirection;

    void Awake()
    {
        rbody = GetComponent<Rigidbody>();
        rbody.useGravity = false;
        rbody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void Start() 
    {
        floating = false;
        bestPlanet = GetBestPlanet();
    }

    public void Respawn()
    {
        bestPlanet = GetBestPlanet();
        floating = false;
    }
    protected GravityProducer GetBestPlanet()
    {
        planets.Sort(delegate(GravityProducer a, GravityProducer b)
        {
            return (Vector3.Distance(this.transform.position, a.transform.position) - a.scale).CompareTo((Vector3.Distance(this.transform.position, b.transform.position) - b.scale));
        });
        return planets[0];
    }

    public void AddGravity()
    {
        bestDirection = (bestPlanet.transform.position - transform.position).normalized;
        if(floating)
        {
            bestPlanet = GetBestPlanet();
            foreach(GravityProducer p in planets)
            {

                gravityForce = (p.transform.position - this.transform.position).normalized;
                float sqrDist = (this.transform.position - p.transform.position).sqrMagnitude;
                float mag = G * p.mass * rbody.mass / sqrDist; 
                gravityForce *= mag;
                rbody.AddForce(gravityForce);
                Debug.DrawLine(transform.position, transform.position + gravityForce, new Color(1,0,1,1));
                
            }

        }

        gravityForce = (bestPlanet.transform.position - this.transform.position).normalized;
        rbody.AddForce(gravityForce * 5f);
        Debug.DrawLine(transform.position, transform.position + gravityForce * 5f, new Color(0,1,1,1));
    } 

    private void FixedUpdate() {
        AddGravity();
    }
}
