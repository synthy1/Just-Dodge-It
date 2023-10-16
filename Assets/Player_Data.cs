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
    [SerializeField]ActionBasedContinuousMoveProvider pMovement;
    XRGrabInteractable currentBall;


    // Update is called once per frame
    void Update()
    {
        pMovement.moveSpeed = moveSpeed;
        ballThrowPower();
    }

    public void OnSelectEnter(SelectEnterEventArgs args)
    {
        currentBall = (XRGrabInteractable)args.interactableObject;
    }

    private void ballThrowPower()
    {
        if(currentBall != null)
        {
            currentBall.throwVelocityScale = throwPower;
        }
    }
}
