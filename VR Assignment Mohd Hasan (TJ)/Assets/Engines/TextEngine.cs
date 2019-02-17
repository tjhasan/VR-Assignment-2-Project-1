using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextEngine : MonoBehaviour
{
    float startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        GetComponent<TextMesh>().text = "Welcome!";
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime > 10)
        {
            GetComponent<TextMesh>().text = "Level 1";
        }

        if (Time.time - startTime > 20)
        {
            GetComponent<TextMesh>().text = "Level 2";
        }

        if (Time.time - startTime > 30)
        {
            GetComponent<TextMesh>().text = "Level 3";
        }

        if (Time.time - startTime > 60)
        {
            GetComponent<TextMesh>().text = "level 4";
        }
    }
}
