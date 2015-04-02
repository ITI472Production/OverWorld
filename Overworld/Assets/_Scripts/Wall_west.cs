using UnityEngine;
using System.Collections;

public class Wall_west : MonoBehaviour {

	void OnCollisionEnter(){
		Player.S.moveleft = false;
	}
	
	void OnCollisionExit(){
		Player.S.moveleft = true;
	}
}
