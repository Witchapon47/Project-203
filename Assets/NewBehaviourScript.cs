using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {





        SceneManager.LoadScene("Menu");


    }
   
}
