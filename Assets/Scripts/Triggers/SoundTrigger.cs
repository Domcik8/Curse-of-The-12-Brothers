using UnityEngine;
using System.Collections;
using System.Runtime.Serialization.Formatters;

public class SoundTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(GetComponent<AudioSource>().clip, gameObject.transform.position);
        }
    }
}