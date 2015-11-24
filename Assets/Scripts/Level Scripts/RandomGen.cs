using UnityEngine;
using System.Collections;

public class RandomGen : MonoBehaviour
{	
	public GameObject g;
	public float range;
	public float count;
	public float size;
	public float y;
	
	void Start ()
	{
		g.GetComponent<Transform>().localScale = new Vector3(size, size, size);
		
		for (var i = 0; i < count; i++)
		{
			Vector3 position = new Vector3(Random.Range(-range, range), y);
			Instantiate(g ,position, Quaternion.identity);
		}
	}
}
