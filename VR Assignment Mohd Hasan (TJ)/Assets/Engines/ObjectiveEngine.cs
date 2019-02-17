using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveEngine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody == null)
        {
            return;
        }

        Rigidbody rb = collision.rigidbody;
        MissileEngine me = rb.GetComponent<MissileEngine>();
        if (me == null)
        {
            return;
        }
        Application.LoadLevel(Application.loadedLevelName);
        Destroy(this.gameObject);
    }
}
