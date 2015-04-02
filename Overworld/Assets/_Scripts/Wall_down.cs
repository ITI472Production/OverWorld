using UnityEngine;
using System.Collections;

public class Wall_down : MonoBehaviour {

	void OnCollisionEnter(){
		Player.S.movedown = false;
	}
	
	void OnCollisionExit(){
		Player.S.movedown = true;
	}

}
