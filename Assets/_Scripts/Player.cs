using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	static public Player S;
	public float speed = 2f;
	public bool moveright = true;
	public bool moveleft = true;
	public bool moveup = true;
	public bool movedown = true;

	void Awake(){
		S = this;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)){
			if(moveright){
				transform.position += Vector3.right * speed * Time.deltaTime;
				return;
			}
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			if(moveleft){
				transform.position += Vector3.left * speed * Time.deltaTime;
				return;
			}
		}
		if(Input.GetKey(KeyCode.DownArrow) && movedown){
			if(movedown){
				transform.position += Vector3.back * speed *Time.deltaTime;
				return;
			}
		}
		if(Input.GetKey(KeyCode.UpArrow) && moveup){
			if(moveup){
				transform.position += Vector3.forward * speed *Time.deltaTime;
				return;
			}
		}
	}

	//sdfkgndlkgndflkgfdfd
}
