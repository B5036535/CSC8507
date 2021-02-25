using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //[SerializeField] Manager GM;

    GravityReceiver pGravity;
    [SerializeField] Transform camera;
    [SerializeField] CameraFollower cameraFollowing;
    PlayerControls inputs;

    Rigidbody rbody;
    [SerializeField] Vector2 inputVector;
    [SerializeField] Vector3 velocity;
    [SerializeField] Vector3 moveDir;

    public Vector3 cameraVector;

    [Min(1)]
    [SerializeField]float speed;
    [Min(1)]
    [SerializeField]float jump;
    [SerializeField]bool jumping;

    float turnSmoothing;
    float turnSmoothingTimer = 0.1f;

    [SerializeField]Vector3 spawnPos;
    public bool won;

    void OnValidate()
    {
        cameraVector = -transform.forward;
    }

    void Awake()
    {
        inputs = new PlayerControls();
        rbody = GetComponent<Rigidbody>();
        pGravity = GetComponent<GravityReceiver>();
        //pGravity.planets = GM.planets;
    }

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        won = false;
        jumping = false;
        //floating = false;
        cameraVector = -transform.forward;
        spawnPos = transform.position;
    }
    void OnEnable() 
    {
       inputs.Enable();
       inputs.PlayerInputs.Jump.performed += _ => Jump();
       inputs.PlayerInputs.Respawn.performed += _ => Respawn();
    }
    void OnDisable() 
    {
       inputs.PlayerInputs.Jump.performed -= _ => Jump();
       inputs.PlayerInputs.Respawn.performed -= _ => Respawn();
       inputs.Disable(); 
    }

    void Jump()
    {
        if(!pGravity.floating)
        {
            pGravity.floating = true;
            jumping = true;
        }

    }

    Vector3 MoveDirection()
    {
        return (camera.right * inputVector.x + camera.forward * inputVector.y).normalized;
    }
    void Rotation()
    {
        Quaternion gravRotation = Quaternion.FromToRotation(transform.up, -pGravity.bestDirection);
        Quaternion lookRotation = Quaternion.FromToRotation(transform.forward, camera.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation,lookRotation * gravRotation * transform.rotation, 20 * Time.fixedDeltaTime);
    }


    void TerminalVelocity()
    {
        if(Vector3.Magnitude(rbody.velocity) >= 10f)
        {
            rbody.AddForce(-rbody.velocity * Vector3.Magnitude(rbody.velocity) / 10f );
        }
    }


    void Winning()
    {

    }

    void Respawn()
    {
        transform.position = spawnPos;
        pGravity.Respawn();
        Rotation();
    }
    // Update is called once per frame
    void Update()
    {
        inputVector = inputs.PlayerInputs.Running.ReadValue<Vector2>();
        velocity = new Vector3(inputVector.x, 0f, inputVector.y);
        Debug.DrawLine(transform.position, transform.position - transform.right * 3, new Color(1,0,0,1));
        Debug.DrawLine(transform.position, transform.position + cameraVector * 3, new Color(1,1,0,1));
        cameraVector = -camera.forward;

    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
            Rotation();
            if(velocity.magnitude >= 0.1f)
            {
                Vector3 forceDir = (this.transform.right * inputVector.x + transform.forward * inputVector.y).normalized;
                rbody.AddForce(forceDir * speed * Time.fixedDeltaTime );
            }
            if(jumping)
            {
                jumping = false;
                rbody.AddForce(this.transform.up * jump / Time.fixedDeltaTime);
            }
            //TerminalVelocity();

            //Rotation();
            //rbody.AddForce(transform.forward * speed * Time.fixedDeltaTime );
    }



}
