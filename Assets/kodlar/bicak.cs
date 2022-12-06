using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bicak : MonoBehaviour
{
    public GameObject bicakPrefab;

    public float bicakLifeTime;

    private bool kesmek;

    private Vector2 swipeStart;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            kesmek = true;
            swipeStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else if(Input.GetMouseButtonUp(0) && kesmek)
        {
            kesmek = false;
            bicakSpawner();
        }
    }
    private void bicakSpawner()
    {
        Vector2 swipeEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject bicakInstance = Instantiate(bicakPrefab, swipeStart, Quaternion.identity);

        bicakInstance.GetComponent<LineRenderer>().SetPosition(0, swipeStart);
        bicakInstance.GetComponent<LineRenderer>().SetPosition(1, swipeEnd);

        Vector2[] collidePoints = new Vector2[2];
        collidePoints[0] = Vector2.zero;
        collidePoints[1] = swipeEnd - swipeStart;

        bicakInstance.GetComponent<EdgeCollider2D>().points = collidePoints;

        Destroy(bicakInstance, bicakLifeTime);
    }
}
