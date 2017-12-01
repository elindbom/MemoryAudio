using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;



public class playSong : MonoBehaviour {

	public Button c;
	public Button g;
	public Button a;
	public Button f;
	public Button e;
	public Button d;

	public List<int> tones;


	public Image panel1;
	public Image panel2;
	public Image panel3;
	public Image panel4;
	public Image panel5;
	public Image panel6;

	void Awake(){
		print ("Skalman");

	}

	// Use this for initialization
	void Start () {

		Debug.Log("hejjd");	



	}
	void FixedUpdate(){
		print ("Time Now: " + DateTime.Now);
	}

	public void ButtonPress(){
		if(c) {
			 
			panel1.color = new Color (0, 167, 255);
			
		}
		if(g) {

			panel2.color = new Color (77, 131, 255);

		}
		if(a) {

			panel3.color = new Color (0, 2, 255);

		}
		if(f) {

			panel4.color = new Color (238, 131, 255);

		}
		if(e) {

			panel5.color = new Color (222, 73, 255);

		}
		if(d) {

			panel6.color = new Color (220, 0, 255);

		}

		//panel2.color = UnityEngine.Color.red;
		//panel3.color = UnityEngine.Color.red;
		//panel4.color = UnityEngine.Color.green;
		//panel5.color = UnityEngine.Color.green;
		//panel6.color = UnityEngine.Color.red;
		//0, 167, 255
	}

	public void PlaySong(){
		DateTime t1 = DateTime.Now;
		print ("t1: " + t1);
		for(int i = 0; i < tones.Count; i++){
			print("tones" + tones[i]);
			if (DateTime.Compare(t1, DateTime.Now) < 10000){
				print ("Compen!!!!!!!");
			}


		}
	}

}
	