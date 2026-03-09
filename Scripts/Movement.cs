using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    VRTracker vrtracker;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (vrtracker.TryGetDeviceRotation(InputDeviceCharacteristics.HeadMounted, out Quaternion headRot))
        {

            this.transform.rotation = headRot;
        }
        //StickMove();
    }

    //void StickMove()
    //{
    //    float speed = 3f;
    //    Vector2 stickR = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
    //    Vector3 changePosition = new Vector3(stickR.x, 0, stickR.y);
//
    //    Vector3 forward = Camera.main.transform.forward;
    //    forward.y = 0f;
    //    Vector3 right = Camera.main.transform.right;
    //    right.y = 0f;
    //    Vector3 moveDirection = (forward * changePosition.z + right * changePosition.x).normalized;
//
    //    transform.position += moveDirection * Time.deltaTime * speed;
    //}
}
