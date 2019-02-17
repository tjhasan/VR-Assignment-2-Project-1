using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEngine : MonoBehaviour
{
    public float speed = .5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed);
        Destroy(this.gameObject, 1);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;
        MissileEngine me = rb.GetComponent<MissileEngine>();
        if (me == null)
        {
            return;
        }
        Destroy(this.gameObject);
        Destroy(collision.gameObject);

    }
}
