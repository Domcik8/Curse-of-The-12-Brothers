using System.Collections;
using UnityEngine;


public class Devil_Controller : MonoBehaviour
{

    GameObject player;
    public float distanceToStart = 20;
    private Animator anim;
    public GameObject[] enemies;
    private Transform spawnPosition;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Mathf.Abs(this.gameObject.transform.position.x - player.transform.position.x) < distanceToStart)
        {

            startBattle();

            GameObject.Find("Boss_attack").GetComponent<Transform_overTime>().enabled = true;

        }
    }

    private void startBattle()
    {

        
        if (GameObject.FindGameObjectsWithTag("Enemy").Length <= 1)
        {
            anim.CrossFade("Devil_hat_animation", 0);
            GameObject enemy = enemies[Random.Range(0, enemies.Length)];
            Instantiate(enemy, new Vector2(this.gameObject.transform.position.x - 3, this.gameObject.transform.position.y - 2.7f), this.gameObject.transform.rotation);

        }


    }


}
