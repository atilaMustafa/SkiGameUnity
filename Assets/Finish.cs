using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float loaddelay = 0.4f;


    void OnTriggerEnter2D(Collider2D other) 
     
    {
        if(other.tag== "oyuncu")
        {
            Invoke("ReloadScene", loaddelay);
            Debug.Log("finish line ");
        }
    }

     void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
