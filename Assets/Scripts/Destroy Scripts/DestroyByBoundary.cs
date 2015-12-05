using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "End")
        {
            Debug.Log(other.gameObject.name + " destroyed by boundary.");
            Destroy(other.gameObject);
        }
    }
}
