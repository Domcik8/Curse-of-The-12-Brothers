using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Text livesText;
    public Text feathersText;
    public float timeToBoss;

    GameObject player;
    Lifes playerLives;
    GirlController playerContr;

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
        playerLives = player.GetComponent<Lifes>();
        playerContr = player.GetComponent<GirlController>();

        Invoke("StopLevel", timeToBoss);
    }
	
	// Update is called once per frame
	void Update () {

        if (playerLives != null)
        {
            livesText.text = "Lives: " + playerLives.life;
            feathersText.text = "Feathers: " + playerContr.featherCount;
        }
	}

    void StopLevel()
    {
        GameObject[] backgrounds = GameObject.FindGameObjectsWithTag("Background");

        foreach (GameObject background in backgrounds)
        {
            if (background.GetComponent<JudejimasKalnas>() != null)
                background.GetComponent<JudejimasKalnas>().StopMovement();
        }

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            if (enemy.GetComponent<SimpleMover>() != null)
                enemy.GetComponent<SimpleMover>().StopMovement();
        }
    }

    public void GirlsDeath()
    {
        StopLevel();
       GameObject.FindGameObjectWithTag("Shadow").GetComponent<Shadow>().ShadowDeath();

    }
}
