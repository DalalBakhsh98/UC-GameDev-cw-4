using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Capsule;
    public GameObject Capsule1;


    void spawn()
    {
        //if i have moree than obsticali could u se this code for it
        //but since im using one thenn i don t need it
        
        GameObject spawnObject;

        int choice = Random.Range(0,2);

        if (choice == 1)
            spawnObject = Capsule;
        else
            spawnObject = Capsule1;  
       

        int newPosition = Random.Range(-1,2);
        Vector3 vPosition = transform.position;
        vPosition.x = vPosition.x + (5 * newPosition);

        GameObject newSpawn = Instantiate(Capsule);
        newSpawn.transform.position = vPosition;


    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 2f, 2f);

    }

    // Update is called once per frame
    void Update()
    {
    
    
        
    }
}
