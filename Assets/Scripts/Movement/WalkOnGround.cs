using UnityEngine;
using System.Collections;

public class WalkOnGround : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " destroyed by boundary.");
        Destroy(other.gameObject);
    }
}
