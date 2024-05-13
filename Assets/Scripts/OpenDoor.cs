using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public Animation hingehere;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            hingehere.Play();
        }
    }
}
