using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;

    void Start()
    {
        InvokeRepeating("Disparo", 2f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Disparo()
    {
        Instantiate(bullet, transform);
    }

}
