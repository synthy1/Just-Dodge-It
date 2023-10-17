using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballThrower : MonoBehaviour
{

    GameObject[] balls;
    public GameObject dodgeBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        balls = GameObject.FindGameObjectsWithTag("Ball");

        if (balls.Length > 6)
        {
            Instantiate(dodgeBall);
        }
    }
}
