using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionZone : MonoBehaviour
{
    TPSController _controller;

    void Awake()
    {
        _controller = GetComponentInParent<TPSController>();
    }

    void OnTriggerEnter(Collider collider) 
    {
        if(collider.gameObject.tag == "Recogible")
        {
            _controller.objectToGrab = collider.gameObject;
        }
    }

    void OnTriggerExit(Collider collider) 
    {
        if(collider.gameObject.tag == "Recogible")
        {
            _controller.objectToGrab = null;
        }
    }
}
