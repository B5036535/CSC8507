using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGFX : MonoBehaviour
{
    PlayerControls inputs;
    Vector3 inputVector;
    Vector3 moveDir;
    [SerializeField] float angle;

    void Awake()
    {
        inputs = new PlayerControls();
    }

    void OnEnable() 
    {
       inputs.Enable();
    }
    void OnDisable() 
    {
       inputs.Disable(); 
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputVector = inputs.PlayerInputs.Running.ReadValue<Vector2>();
        moveDir = new Vector3(inputVector.x, 0, inputVector.y);

        angle = Mathf.Atan2(moveDir.x,moveDir.z) * Mathf.Rad2Deg;

        Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.up);

        if (Vector3.Magnitude(moveDir) > 0.0f)
        {
            transform.localRotation = targetRotation;
        }
    }
}
