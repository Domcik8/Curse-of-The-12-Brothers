using UnityEngine;
using System.Collections;

public class DamageTrigger : MonoBehaviour
{
    public int damage;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Lifes lifes = other.gameObject.GetComponent<Lifes>();
            lifes.addlife(-damage);
        }
    }
}
