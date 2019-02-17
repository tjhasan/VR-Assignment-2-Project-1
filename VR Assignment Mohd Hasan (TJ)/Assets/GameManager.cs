using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float mSpeed;
    public float mSpawnerRate_sec;
    public float mSpawnRadius;
    public Transform mSpawnOrigin;
    float lastSpawn;
    float startTime;
    public MissileEngine missilePrefab;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        lastSpawn = Time.time;
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastSpawn > mSpawnerRate_sec && target != null)
        {
            MissileEngine me = Instantiate<MissileEngine>(missilePrefab);
            me.transform.position = mSpawnOrigin.position +
                Random.Range(-1.0f, 1.0f) * mSpawnRadius * mSpawnOrigin.right +
                Random.Range(-1.0f, 1.0f) * mSpawnRadius * mSpawnOrigin.forward;
            Rigidbody rb = me.GetComponent<Rigidbody>();
            if (target != null)
            {
                rb.velocity = (target.position - me.transform.position).normalized * mSpeed;
            }
            lastSpawn = Time.time;
        }
       
        if(Time.time - startTime > 10)
        {
            mSpeed = 2;
            mSpawnerRate_sec = 5;
        }

        if (Time.time - startTime > 20)
        {
            mSpeed = 3;
            mSpawnerRate_sec = 3;
        }

        if(Time.time - startTime > 30)
        {
            mSpeed = 4;
            mSpawnerRate_sec = 1;
        }

        if (Time.time - startTime > 60)
        {
            mSpeed = 5;
            mSpawnerRate_sec = 1;
        }
        
    }
}
