using UnityEngine;
using System.Collections;

public class BossSpawn : MonoBehaviour {

    // Use this for initialization

    GameObject[] backgrounds;
    public GameObject bossPrefab;
    public Transform bossPosition;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        backgrounds = GameObject.FindGameObjectsWithTag("Background");

        //Debug.Log("Labas");

        if (other.gameObject.tag == "Player")
        {

            //Debug.Log("Labas2");
            foreach (GameObject background in backgrounds)
            {
                background.GetComponent<JudejimasKalnas>().StopMovement();
            }

            Instantiate(bossPrefab, bossPosition.position, bossPosition.rotation);
            this.gameObject.SetActive(false);
        }
    }
}
