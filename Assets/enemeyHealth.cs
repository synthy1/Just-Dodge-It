using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemeyHealth : MonoBehaviour
{
    [SerializeField] Enemy_Data enemyData;

    private void Start()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
    }
    // Update is called once per frame
    void Update()
    {
        enemyData = FindAnyObjectByType<Enemy_Data>();

        
    }
}
