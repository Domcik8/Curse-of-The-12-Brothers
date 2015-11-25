using UnityEngine;
using System.Collections;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

public class Shadow : MonoBehaviour {

    public GameObject player;
    GameObject ground;

    public float shadowW = 10;
    public float shadowH = 7;
    float distance = 0;


    // Use this for initialization
    void Start () {
         ground = GameObject.FindGameObjectWithTag("Ground");
      
	}

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            distance = player.transform.position.y - gameObject.transform.position.y;
            gameObject.transform.position = new Vector2(player.transform.position.x , ground.transform.position.y + 0.5f);
            gameObject.transform.localScale = new Vector2(shadowW / distance, shadowH / distance);
        }
    }

    public void ShadowDeath()
    {
        gameObject.transform.localScale = new Vector2(shadowW / distance * 2, shadowH / distance);

    }
}
