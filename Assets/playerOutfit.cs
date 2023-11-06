using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerOutfit : MonoBehaviour
{
    [Header("clothing")]
    [SerializeField] GameObject top;
    [SerializeField] GameObject shoes;

    [Header("array of shop items")]

    public GameObject[] unlocked;
}
