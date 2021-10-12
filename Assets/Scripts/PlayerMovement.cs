using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 scale = new Vector3(2,1,2);
    public Vector3 dir = new Vector3(1, 0, 0);
    public float vel = 2f;
    public GameObject allyPlayer;

    void Start()
    {
        transform.localScale = scale;
        Debug.Log(allyPlayer.GetComponent<Ally>().NameAlly());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * vel * Time.deltaTime;
    }
}
