using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{
    public void opentornys()
    {
        Debug.Log("jkhnergjkhnfdgjkn");
    }

    public void TornyOne()
    {
        SceneManager.LoadScene(1);
    } 
    public void TornyTwo()
    {
        SceneManager.LoadScene(2);
    }
    public void TornyTrain()
    {
        SceneManager.LoadScene(3);
    }
}
