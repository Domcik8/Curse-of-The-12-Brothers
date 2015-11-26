using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MeniuController : MonoBehaviour {

	public Canvas c;
	public Button play;
	public Button controls;
	public Button credits;
	public Button exit;
	public Image i;
	public Text t1;
	public Text t2;
	public Image logo;
	public Image name1;
	public Text name2;

	void Start()
	{
		StartCoroutine (Waiting ());

		c = c.GetComponent<Canvas> ();
		play = play.GetComponent<Button> ();
		controls = controls.GetComponent<Button> ();
		credits = credits.GetComponent<Button> ();
		exit = exit.GetComponent<Button> ();
		i = i.GetComponent<Image> ();
		t1 = t1.GetComponent<Text> ();
		t2 = t2.GetComponent<Text> ();
		logo = logo.GetComponent<Image> ();
		i.enabled = false;
		t1.enabled = false;
		t2.enabled = false;
		logo.enabled = false;
	}

	public void Play()
	{
		Application.LoadLevel (1);
	}

	public void Controls ()
	{
		play.enabled = false;
		controls.enabled = false;
		credits.enabled = false;
		exit.enabled = false;
		i.enabled = true;
		t1.enabled = true;
	}

	public void Credits ()
	{
		play.enabled = false;
		controls.enabled = false;
		credits.enabled = false;
		exit.enabled = false;
		i.enabled = true;
		t2.enabled = true;
		logo.enabled = true;
	}

	public void Exit ()
	{
		Application.Quit ();
	}

	void Update()
	{
		if (t1.IsActive() && Input.GetKey (KeyCode.Escape))
		{
			i.enabled = false;
			t1.enabled = false;
			play.enabled = true;
			controls.enabled = true;
			credits.enabled = true;
			exit.enabled = true;
		}

		if (t2.IsActive() && Input.GetKey (KeyCode.Escape))
		{
			i.enabled = false;
			t2.enabled = false;
			play.enabled = true;
			controls.enabled = true;
			credits.enabled = true;
			exit.enabled = true;
			logo.enabled = false;
		}
	}

	IEnumerator Waiting()
	{
		yield return new WaitForSeconds(5f);
		name1.GetComponent<Image>().enabled = false;
		name2.GetComponent<Text> ().enabled = false;
		
		yield break;
	}
}
