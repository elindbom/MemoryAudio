using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answerColor : MonoBehaviour {

	public Image panel1;
	public Image panel2;
	public Image panel3;
	public Image panel4;
	public Image panel5;
	public Image panel6;


	// Use this for initialization
	void Start () {
		//if(){


		//}
		panel1.color = UnityEngine.Color.green;
		panel2.color = UnityEngine.Color.red;
		panel3.color = UnityEngine.Color.red;
		panel4.color = UnityEngine.Color.green;
		panel5.color = UnityEngine.Color.green;
		panel6.color = UnityEngine.Color.red;
	}
}




//
//public class PanelColorer : MonoBehaviour {
//
//	Image panel;
//
//	void Start(){
//		//Right here. Make sure there's an image component attached,
//		//or it will throw an error in Update()
//		panel = GetComponent<Image>();
//	}
//
//	void Update(){
//		panel.color = GetRandomColor();
//	}
//
//	Color GetRandomColor(){
//		return new Color(Random.value, Random.value, Random.value);
//	}
//
//}