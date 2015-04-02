using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public bool GUITextSky = false;
	public GUIText EnterSKIGUI;

	public void OnCollisionEnter(){
		bool GuiTEXTSky = true;
		OnGUI ();
	}

	void OnGUI(){
		if(Input.GetKey(KeyCode.Space)){
			Application.LoadLevel ("_Scene_0");
		}
	}

}
