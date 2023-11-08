using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwball : MonoBehaviour
{
    float timerend = 3f;
    [SerializeField]float timer = 0f;

    public GameObject ball;
    Enemy_Data data;
    private void Start()
    {
        data = gameObject.GetComponentInParent<Enemy_Data>();
    }
    // Update is called once per frame
    void Update()
    {
        Timerchange();
    }

    private void Timerchange()
    {
        if (timer < timerend)
        {
            timer += Time.deltaTime;
        }
        else if (timer >= timerend)
        {
            timer = 0f;
            Instantiate(ball, gameObject.transform.position,gameObject.transform.rotation).GetComponent<Rigidbody>().AddForce((gameObject.transform.forward + new Vector3(1, 0, 0) * data.throwPower + Vector3.up) , ForceMode.Impulse);
        }

    }
}
