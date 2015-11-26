using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lifes : MonoBehaviour
{
    public Image blanc; //cia!!!!!!!!
    public Text gameover; //cia!!!!!!!!
    public Text nextlevel;

    public float life;
    public float deathDelay;

    private Animator anim;
    Animator animator;
    private Rigidbody2D rb;
    private Collider2D coll;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (life <= 0)
        {
            if (this.gameObject.tag == "Enemy")
            {
                rb.constraints = RigidbodyConstraints2D.FreezePositionY;
                coll.enabled = false;
                anim.SetBool("Dead", true);
                GetComponent<PhysicsMover>().enabled = false;
                DeactivateChildren(this.gameObject ,false);

                GetComponent<BossController>().notDead = false;
            }

            if (this.gameObject.tag == "Player")
            {
                StartCoroutine(GameOverText());
                gameObject.GetComponent<Animator>().SetBool("Dead", true);
                gameObject.GetComponent<GirlController>().isDead = true;
                GameObject.FindGameObjectWithTag("GM").GetComponent<GameManager>().GirlsDeath();
            }

            Destroy(gameObject, deathDelay);
        }


    }

    public void addlife(float live)
    {
        life += live;
    }


    void DeactivateChildren(GameObject g, bool a)
    {

        Transform child = transform.FindChild("Trigger");

        if (child != null)
        {
            child.gameObject.SetActive(false);
        }
    }

    IEnumerator GameOverText()
    {
        yield return new WaitForSeconds(2f);
        blanc.GetComponent<Image>().enabled = true;
        gameover.GetComponent<Text>().enabled = true;
        yield return new WaitForSeconds(5f);
        Application.LoadLevel(0);

        yield break;
    }
}