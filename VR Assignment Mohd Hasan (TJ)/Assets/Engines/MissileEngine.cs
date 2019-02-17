using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileEngine : MonoBehaviour
{
    public AudioClip shoot;
    private AudioSource source;
    private float volLowRange = .5f;
    private float colHighRange = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        source.PlayOneShot(shoot, 1f);
        Destroy(this.gameObject, 10);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;
        ObjectiveEngine oe = rb.GetComponent<ObjectiveEngine>();
        if (oe == null)
        {
            return;
        }
        Destroy(this.gameObject);
        
    }
}
