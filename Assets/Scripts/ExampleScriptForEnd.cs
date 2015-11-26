using UnityEngine;
using System.Collections;
using UnityEngine.UI; //cia!!!!!!!!

public class ExampleScriptForEnd : MonoBehaviour
{
	
	public Image blanc; //cia!!!!!!!!
	public Text gameover; //cia!!!!!!!!
	public Text nextlevel; //cia!!!!!!!!

	void Update ()
	{
		StartCoroutine (GameOverText ());
		StartCoroutine (NextLevel ());
	}

	IEnumerator GameOverText()
	{
		blanc.GetComponent<Image>().enabled = false;
		gameover.GetComponent<Text> ().enabled = false;
		yield return new WaitForSeconds(5f);
		Application.LoadLevel (Application.loadedLevel);
		
		yield break;
	}

	IEnumerator NextLevel()
	{
		blanc.GetComponent<Image>().enabled = false;
		nextlevel.GetComponent<Text> ().enabled = false;
		yield return new WaitForSeconds(5f);
		Application.LoadLevel (3);
		
		yield break;
	}
}
