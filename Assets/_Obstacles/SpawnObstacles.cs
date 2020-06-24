using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject[] spawn;
    int spawnTime = 1;   
    float spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObject", spawnTime, 1);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void spawnObject()
    {
        int ramdomObstacle = Random.Range(0, spawn.Length);
        spawnPosition =  Random.Range(1.5f, -1.5f);
        this.transform.position = new Vector3(spawnPosition, transform.position.y, transform.position.z);
        Instantiate(spawn[ramdomObstacle], transform.position, transform.rotation);

    }
}
