using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

    public int damage = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log(coll.gameObject.name + " has beed attacked.");
        if (coll.gameObject.tag == "Enemy" || coll.gameObject.tag == "Boss")
        {
            coll.gameObject.GetComponent<Lifes>().addlife(-damage);
            Destroy(gameObject);
        }

        if (coll.gameObject.tag == "EnemyBullet")
        {
            Destroy(coll.gameObject);
            Destroy(gameObject);
        }
            
    }
}
