using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy_Data : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] public float Health = 100f;
    [SerializeField] float throwPower = 5f;
    [SerializeField] float moveSpeed = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            Health -= 25f;
            //play sfx
        }
    }
}
