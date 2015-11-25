using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour {
	
	public GameObject wave;
	public Transform spawn;
	private float nextFire;
	public float fireRate = 0.5f;
	private int count = 0;
	public Animator animator;
    public bool notDead = true;


	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
        if(GameObject.FindWithTag("Player") != null)
	        fireRate = this.gameObject.transform.position.x -
	                   GameObject.FindWithTag("Player").GetComponent<Transform>().position.x;

	    if (fireRate > 0.7f) fireRate = 0.7f;
     
		if ((Time.time > nextFire) && notDead)
        {
			nextFire = Time.time + fireRate;
			Instantiate (wave, spawn.position, spawn.rotation);

		}
	}
}
