using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Observer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI TMPWin;

    PlayerControls inputs;

    void Awake()
    {
        inputs = new PlayerControls();
    }

    void OnEnable() 
    {
       inputs.Enable();
       inputs.PlayerInputs.Respawn.performed += _ => Respawn();
    }
    void OnDisable() 
    {
       inputs.PlayerInputs.Respawn.performed -= _ => Respawn();
       inputs.Disable(); 
    }


    public void EndGame()
    {
        TMPWin.enabled = true;
    }

    public void Respawn()
    {
        TMPWin.enabled = false;
    }

}
