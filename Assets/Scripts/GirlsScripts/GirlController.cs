using UnityEngine;
using System.Collections;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class GirlController : MonoBehaviour {

    Time lastShot;

    public int speed = 10000;
    public int jumpForce = 35000;
    public bool isOnGround = false;
    public int dealDemage = 1;

    private float nextFire;
    public float fireRate = 0.5f;
    public int featherCount = 20;

    public GameObject shot;
    public GameObject shotSpawn;
    public GameObject shadow;
	// Use this for initialization
	void Start () {
        Instantiate(shadow, gameObject.transform.position, gameObject.transform.rotation); 
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            isOnGround = false;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }

        if (Input.GetKeyDown (KeyCode.Z) && (featherCount > 0) && (Time.time > nextFire))
        {
            nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.transform.position, shotSpawn.transform.rotation);
		    GetComponent<AudioSource>().Play();
			featherCount--;
		}
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Game information: " + gameObject.name + " on enter triggered " + other.gameObject.name);
        switch (other.gameObject.tag)
        {
            case "Feather":
                featherCount++;
                Destroy(other.gameObject.transform.parent.gameObject);
                break;

            case "Bullet":
                break;

            case "End":
                Application.LoadLevel(0);
                break;

            default:
                PerlinShake shaker = Camera.main.GetComponent<PerlinShake>();
                shaker.PlayShake();
                break;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        //Debug.Log("Game information: " + gameObject.name + " collided with " + other.gameObject.name);
        switch (other.gameObject.tag)
        {
            case "Ground":
                isOnGround = true;
                break;
        }
    }
}
