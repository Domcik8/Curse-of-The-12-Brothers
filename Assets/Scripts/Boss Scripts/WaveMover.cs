
using UnityEngine;
using System.Collections;

public class WaveMover : MonoBehaviour {

	public float speed =1.0f;

	void Update (){

		Vector3 position = this.transform.position;
		position.x -= speed;
		this.transform.position = position;
	}

}
