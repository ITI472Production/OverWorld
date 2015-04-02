using UnityEngine;
using System.Collections;

public class Wall_north : MonoBehaviour {

	void OnCollisionEnter(){
		Player.S.moveup = false;
	}
	
	void OnCollisionExit(){
		Player.S.moveup = true;
	}

}
