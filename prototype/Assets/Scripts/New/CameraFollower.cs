using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{

    PlayerControls inputs;
    [SerializeField] Player player;

    [SerializeField] Vector2 offset;
    [SerializeField] float pitch;
    public float yaw;
    [SerializeField] float playerAngle;

    Vector3 cameraToPlayer;
    Vector3 playerToCamera;

    float delta;
    void Awake()
    {
        inputs = new PlayerControls();
    }

    void Start() 
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void OnEnable() 
    {
        inputs.Enable();
    }
    void OnDisable() 
    {
        inputs.Disable();
    }
    void OnValidate() 
    {

        SetOrientation();
        SetPosition();
        
    }

    void Update()
    {
        delta = inputs.Mouse.Look.ReadValue<Vector2>().x * 0.5f;
        yaw += inputs.Mouse.Look.ReadValue<Vector2>().x * 0.0001f;
        yaw %= 360;

        playerAngle = Vector3.Angle(transform.up, player.transform.up);

        SetOrientation();
        SetPosition();


    }
    void SetPosition()
    {
        transform.position = player.cameraVector * offset.x + player.transform.up * offset.y + player.transform.position;     
    }

    void SetOrientation()
    {

        Quaternion upright = Quaternion.FromToRotation(transform.up, player.transform.up);


        Quaternion atPlayer = Quaternion.AngleAxis(delta, transform.up);
        transform.rotation = Quaternion.Slerp(transform.rotation,  atPlayer * upright * transform.rotation, 50 * Time.deltaTime);
        //transform.rotation = Quaternion.Slerp(transform.rotation,   upright * transform.rotation, 20 * Time.deltaTime);

    }
}
