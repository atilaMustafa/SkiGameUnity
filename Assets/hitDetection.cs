using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hitDetection : MonoBehaviour

{
    [SerializeField] float loaddelay = 1f;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag=="Ground")
        {
            Debug.Log("hit");
            Invoke("ReloadScene", loaddelay);
        }
    
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
