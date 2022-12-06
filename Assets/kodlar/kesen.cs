using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kesen : MonoBehaviour
{
    private manager manager;

    private void Start()
    {
        manager = GameObject.FindObjectOfType<manager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "fruit")
        {
            Destroy(other.gameObject);
            manager.score += 1;
        }
        else if (other.gameObject.CompareTag("bomb"))
        {
            manager.restart();
        }
    }
}
