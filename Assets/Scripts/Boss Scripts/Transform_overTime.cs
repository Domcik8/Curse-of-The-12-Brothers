using UnityEngine;
using System.Collections;

public class Transform_overTime : MonoBehaviour {

    public float speed = 0.0005f;
    public float movementSpeed = 0.005f;
    public float deathSpeed = 0.1f;
    public float deathMovementSpeed = 0.5f;
    public bool bossDead = false;
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

        if (!bossDead)
        {
            this.gameObject.transform.localScale = new Vector2(this.gameObject.transform.localScale.x + speed, this.gameObject.transform.localScale.y);
            this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x - movementSpeed, this.gameObject.transform.position.y);
           // Debug.Log("bigger");
        }
        else {
            this.gameObject.transform.localScale = new Vector2(this.gameObject.transform.localScale.x - speed, this.gameObject.transform.localScale.y);
            this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x + movementSpeed, this.gameObject.transform.position.y);
            if (this.gameObject.transform.localScale.x < 0)
                Destroy(gameObject);
           // Debug.Log("Smaller");
        }
    }
}

