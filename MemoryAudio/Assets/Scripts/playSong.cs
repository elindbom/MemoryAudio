using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class playSong : MonoBehaviour {

	public Button c;
	public Button g;
	public Button a;
	public Button f;
	public Button e;
	public Button d;

	public List<int> tones;


	void Awake(){
		print ("Skalman");
	}

	// Use this for initialization
	void Start () {

		Debug.Log("hejjd");	
	}

	public void PlaySong(){
		for(int i = 0; i < tones.Count; i++){
			print(tones[i]);

		}
	}

}
