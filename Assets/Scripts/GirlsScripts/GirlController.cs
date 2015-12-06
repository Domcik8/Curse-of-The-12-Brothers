using UnityEngine;
using System.Collections;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using UnityEngine.UI; //cia!!!!!!!!

public class GirlController : MonoBehaviour {
    public Image blanc; //cia!!!!!!!!
    public Text gameover; //cia!!!!!!!!
    public Text nextlevel; //cia!!!!!!!!
    Time lastShot;

    public int speed = 10000;
    public int jumpForce = 35000;
    public bool isOnGround = false;
    public int dealDemage = 1;
    public bool bossFight = false;
    public bool isDead = false;

    private float nextFire;
    public float fireRate = 0.5f;
    public int featherCount = 20;

    public GameObject shot;
    public GameObject shotSpawn;
    public GameObject shadow;

    
    Animator anim;

	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
        anim.SetBool("Jump", true);
	}
	
	// Update is called once per frame
	void Update () {

        gameObject.GetComponent<Rigidbody2D>().WakeUp();

        if (Input.GetKey(KeyCode.A) && !isDead)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            anim.SetBool("Run", true);
        }
        if (Input.GetKey(KeyCode.D) && !isDead)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            anim.SetBool("Run", true);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !isDead)
        {
            isOnGround = false;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            anim.SetBool("Jump", true);
        }

        if (Input.GetKeyDown (KeyCode.Z) && (featherCount > 0) && (Time.time > nextFire) && !isDead)
        {
            nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.transform.position, shotSpawn.transform.rotation);
		    GetComponent<AudioSource>().Play();
			featherCount--;
		}

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(0);
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
                //Application.LoadLevel(0);
                StartCoroutine(NextLevel());
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
                anim.SetBool("Jump", false);
                break;
        }
    }

    IEnumerator NextLevel()
    {
        blanc.GetComponent<Image>().enabled = true;
        nextlevel.GetComponent<Text>().enabled = true;
        yield return new WaitForSeconds(5f);
        Application.LoadLevel(3);

        yield break;
    }
}
