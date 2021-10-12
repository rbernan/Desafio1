using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    public int life = 0;
    public float vel = 0;
    public string dir;
    public string allyName;
    // Start is called before the first frame update
    void Start()
    {
        IncreaseLife(100000);
    }

    // Update is called once per frame
    void Update()
    {
        ReduceLife(50);
        AllyMovement(dir, vel);

    }

    void AllyMovement(string dir, float vel)
    {
        if(dir == "sur")
        {
            transform.position += new Vector3(1, 0, 0) * vel * Time.deltaTime;
        } else if(dir == "norte")
        {
            transform.position += new Vector3(-1, 0, 0) * vel * Time.deltaTime;
        }
        else if (dir == "este")
        {
            transform.position += new Vector3(0, 0, 1) * vel * Time.deltaTime;
        } else
        {
            transform.position += new Vector3(0, 0, -1) * vel * Time.deltaTime;
        }

    }

    void IncreaseLife(int amount)
    {
        life += amount;
    }

    void ReduceLife(int amount)
    {
        life -= amount ;
    }
       
    public string NameAlly()
    {
        allyName = "machete";
        return name;
    }

}


