using UnityEngine;
using System.Collections;

public class DamageOverTime : MonoBehaviour {

    public float damage = 0;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Lifes lifes = other.gameObject.GetComponent<Lifes>();
            lifes.addlife(-damage);
        }
    }
}
