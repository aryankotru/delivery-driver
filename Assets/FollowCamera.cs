using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingtofollow;
    //position of camera should be same as the car
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called once per frame, at the very end of the instruction execute cycle
    void LateUpdate()
    {
        transform.position= thingtofollow.transform.position+new Vector3(0,0,-10);
    }
}
