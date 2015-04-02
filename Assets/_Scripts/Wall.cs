using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	void OnCollisionEnter(){
		Player.S.moveright = false;
	}

	void OnCollisionExit(){
		Player.S.moveright = true;
	}

}
