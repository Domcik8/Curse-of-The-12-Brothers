using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour {
	
	public GameObject wave;
	public Transform spawn;
	private float nextFire;
    public float boosFireRate = 1;
	float fireRate = 0.5f;
	private int count = 0;
	public Animator anim;
    public bool notDead = true;
    private GameObject player;
    public float distanceToStart;

    void Start () {
		anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update ()
	{


        if ((Mathf.Abs(this.gameObject.transform.position.x - player.transform.position.x) < distanceToStart) && notDead)
        {
            shoot();
        }

    }

    public void shoot()
    {


        anim.Play("witchAttack", 0);

        if (GameObject.FindWithTag("Player") != null)
            fireRate = this.gameObject.transform.position.x - player.GetComponent<Transform>().position.x;

        if (fireRate > boosFireRate)
            fireRate = boosFireRate;

        if ((Time.time > nextFire) && notDead)
        {
            nextFire = Time.time + fireRate;
            Instantiate(wave, spawn.position, spawn.rotation);

        }
    }
}
