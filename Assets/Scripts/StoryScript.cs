using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StoryScript : MonoBehaviour
{
	public Image i1;
	public Image i2;
	public Image i3;
	public Image i4;
	public Image i5;
	public Image i6;
	public Image i7;
	public Image i8;
	public Image i9;
	public Image i10;
	public Image i11;
	bool b = false;
	//Renderer renderer = new Renderer ();

	void Start ()
	{

		//renderer.enabled = false;
		//i1;
		/*i2.enabled = false;
		i3.enabled = false;
		i4.enabled = false;
		i5.enabled = false;
		i6.enabled = false;
		i7.enabled = false;
		i8.enabled = false;
		i9.enabled = false;
		i10.enabled = false;
		i11.enabled = false;*/

		StartCoroutine (Waiting ());


	}

	void Update()
	{

	}

	IEnumerator Waiting()
	{
		b = true;

		yield return new WaitForSeconds(3f);
		i2.GetComponent<Image>().enabled = true;
		yield return new WaitForSeconds(3f);
		i3.GetComponent<Image>().enabled = true;
		i3.GetComponentInChildren<Text> ().enabled = true;
		yield return new WaitForSeconds(3f);
		i4.GetComponent<Image>().enabled = true;
		yield return new WaitForSeconds(3f);
		i5.GetComponent<Image>().enabled = true;
		i5.GetComponentInChildren<Text> ().enabled = true;
		yield return new WaitForSeconds(3f);
		i6.GetComponent<Image>().enabled = true;
		yield return new WaitForSeconds(3f);
		i7.GetComponent<Image>().enabled = true;
		i7.GetComponentInChildren<Text> ().enabled = true;
		yield return new WaitForSeconds(3f);
		i8.GetComponent<Image>().enabled = true;
		yield return new WaitForSeconds(3f);
		i9.GetComponent<Image>().enabled = true;
		i9.GetComponentInChildren<Text> ().enabled = true;
		yield return new WaitForSeconds(3f);
		i10.GetComponent<Image>().enabled = true;
		yield return new WaitForSeconds(3f);
		i11.GetComponent<Image>().enabled = true;
		i11.GetComponentInChildren<Text> ().enabled = true;
		yield return new WaitForSeconds(5f);
		Application.LoadLevel (2);

		yield break;
	}
}
