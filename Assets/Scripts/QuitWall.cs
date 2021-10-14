using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitWall : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
