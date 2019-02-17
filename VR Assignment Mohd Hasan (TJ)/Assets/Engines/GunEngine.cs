using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEngine : MonoBehaviour
{
    public AudioClip shoot;
    private AudioSource source;
    private float volLowRange = .5f;
    private float colHighRange = 1.0f;

    public float bSpawnRate_sec;
    float lastSpawn;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        lastSpawn = Time.time;
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger, OVRInput.Controller.LTouch) > 0 ||
            OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger, OVRInput.Controller.RTouch) > 0)
        {
            if(Time.time - lastSpawn > bSpawnRate_sec)
            {
                Instantiate(bullet, transform.position, transform.rotation);
                source.PlayOneShot(shoot, 1f);
                lastSpawn = Time.time;
            }
        }
    }
}
