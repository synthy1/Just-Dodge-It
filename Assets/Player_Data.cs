using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Player_Data : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] public float maxHealth = 100f;
    [SerializeField] public float Health;
    [SerializeField] float throwPower = 5f;
    [SerializeField] float moveSpeed = 10f;


    [Header("refrences")]
    ActionBasedContinuousMoveProvider pMovement;
    XRGrabInteractable currentBall;
    XRController Lcont;
    XRController Rcont;



    // Start is called before the first frame update
    void Start()
    {
        Lcont = GameObject.Find("Left Controller").GetComponent<XRController>();
        Rcont = GameObject.Find("Right Controller").GetComponent<XRController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void ballThrowPower()
    {
        currentBall = gameObject;
        if(currentBall != null)
        {
            currentBall.throwVelocityScale = throwPower;
        }
    }*/
}
