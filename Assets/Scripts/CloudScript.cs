//Libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//The main class of this script
public class CloudScript: MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World");
        Debug.Log(this.name);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Frame");
        this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y, this.transform.position.z + (speed * Time.deltaTime));
    }
}
