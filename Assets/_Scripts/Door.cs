﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Door : MonoBehaviour {

	public bool Space_Check = false;
	public bool Player_Lock = true;
	public GUIText SkyGUI;
	public Object SkyObject;

	public void OnCollisionEnter(){
		Space_Check = true;
		if (Player_Lock == true) {
			SkyObject = Instantiate(SkyGUI);
			LockMovement();
		}
	}

	public void OnCollisionExit(){
		Space_Check = false;
		Player_Lock = true;
		Player.S.moveright = true;
		Destroy(SkyObject);
	}

	void Update(){
		if(Input.GetKey(KeyCode.Space) && Space_Check == true){
			Application.LoadLevel("_Scene_0");
		}
		if(Input.GetKey (KeyCode.Backspace)){
			Destroy(SkyObject);
			Player_Lock = false;
			UnLockMovement();
		}
	}

	public void LockMovement(){
		Player.S.moveup = false;
		Player.S.movedown = false;
		Player.S.moveleft = false;
		Player.S.moveright = false;
	}
	
	public void UnLockMovement(){
		Player.S.moveup = true;
		Player.S.movedown = true;
		Player.S.moveleft = true;
	}

}
