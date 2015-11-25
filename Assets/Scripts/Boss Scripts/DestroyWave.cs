using UnityEngine;
using System.Collections;

public class DestroyWave : MonoBehaviour {

    private Collider coll;
    private int damage=10;
    public float destroyTime = 2;

    void Start()
    {
        Invoke("DestroyWaveByTime", destroyTime);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            coll.gameObject.GetComponent<Lifes>().addlife(-damage);
            Destroy(gameObject);
        }
    }

    void DestroyWaveByTime()
    {
        Destroy(gameObject);
    }
}
