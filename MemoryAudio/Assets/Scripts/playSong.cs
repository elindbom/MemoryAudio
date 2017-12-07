using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
//using UnityEngine.Color;



public class playSong : MonoBehaviour {

	public Button c;
	public Button g;
	public Button a;
	public Button f;
	public Button e;
	public Button d;

	public List<Button> tones;


	public Image panel1;
	public Image panel2;
	public Image panel3;
	public Image panel4;
	public Image panel5;
	public Image panel6;

	private int iet;
	private Image pan;

	private List<Image> panels;

	public AudioClip audioClip1;
	public AudioClip audioClip2;
	public AudioClip audioClip3;
	public AudioClip audioClip4;

	private List<AudioClip> sounds;

	public int number;

	public Button choise1;
	public Button choise2;
	public Button choise3;
	public Button choise4;

	private int theChoise;

	void Start () {

		Debug.Log("hejjd");	
		tones = new List<Button> ();
		tones.Add(c);
		tones.Add(g);
		tones.Add(a);
		tones.Add(g);
		tones.Add(a);
		iet = 0; //Iterationen

		panels = new List<Image> ();
		panels.Add (panel1);
		panels.Add (panel2);
		panels.Add (panel3);
		panels.Add (panel4);
		panels.Add (panel5);
		panels.Add (panel6);

		sounds = new List<AudioClip> ();
		sounds.Add (audioClip1);
		sounds.Add (audioClip2);
		sounds.Add (audioClip3);
		sounds.Add (audioClip4);

		c.enabled = false;
		g.enabled = false;
		a.enabled = false;
		f.enabled = false;
		e.enabled = false;
		d.enabled = false;
	}

	public void ButtonPress(){
		print ("Tryckt!!!!!!!!!");



		if(theChoise == 1){
			if (iet < 3) {
				pan = panels [iet];
				if (iet == 0) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == c) {
						pan.color = c.colors.normalColor;
					} else {
						pan.color = UnityEngine.Color.red;
					}
				}

				if (iet == 1) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == g) {
						pan.color = g.colors.normalColor;
						DisableButtons ();
					} else {
						pan.color = UnityEngine.Color.red;
						DisableButtons ();
					}
				}
				iet += 1;
			} else {
				DisableButtons ();
			}
		}







		if (theChoise == 2) {
			if (iet < 4) {
				pan = panels [iet];
				if (iet == 0) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == c) {
						pan.color = c.colors.normalColor;
					} else {
						pan.color = UnityEngine.Color.red;
					}
				}

				if (iet == 1) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == g) {
						pan.color = g.colors.normalColor;
					} else {
						pan.color = UnityEngine.Color.red;
					}
				}

				if (iet == 2) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == a) {
						pan.color = a.colors.normalColor;
						DisableButtons ();
					} else {
						pan.color = UnityEngine.Color.red;
						DisableButtons ();
					}
				}
				iet += 1;
			} else {
				DisableButtons ();
			}
		}






		if (theChoise == 3) {
			if (iet < 5) {
				pan = panels [iet];
				if (iet == 0) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == c) {
						pan.color = c.colors.normalColor;
					} else {
						pan.color = UnityEngine.Color.red;
					}
				}

				if (iet == 1) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == g) {
						pan.color = g.colors.normalColor;
					} else {
						pan.color = UnityEngine.Color.red;
					}
				}

				if (iet == 2) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == a) {
						pan.color = a.colors.normalColor;
					} else {
						pan.color = UnityEngine.Color.red;
					}
				}
				if (iet == 3) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == f) {
						pan.color = f.colors.normalColor;
						DisableButtons ();
					} else {
						pan.color = UnityEngine.Color.red;
						DisableButtons ();
					}
				}
				iet += 1;
			} else {
				DisableButtons ();
			}

		}







		if (theChoise == 4) {
			if (iet < 6) {
				pan = panels [iet];
				if (iet == 0) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == c) {
						pan.color = c.colors.normalColor;
						print ("Tryckt på RÄTT knapp");
					} else {
						pan.color = UnityEngine.Color.red;
						print ("Tryckt på FEL knapp");
					}
				}

				if (iet == 1) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == g) {
						pan.color = g.colors.normalColor;
						print ("Tryckt på RÄTT knapp 2");
					} else {
						pan.color = UnityEngine.Color.red;
						print ("Tryckt på FEL knapp 2");
					}
				}

				if (iet == 2) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == a) {
						pan.color = a.colors.normalColor;
						print ("Tryckt på RÄTT knapp 3");
					} else {
						pan.color = UnityEngine.Color.red;
						print ("Tryckt på FEL knapp 3");
					}
				}
				if (iet == 3) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == f) {
						pan.color = f.colors.normalColor;
						print ("Tryckt på RÄTT knapp 4");
					} else {
						pan.color = UnityEngine.Color.red;
						print ("Tryckt på FEL knapp 4");
					}
				}

				if (iet == 4) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == e) {
						pan.color = e.colors.normalColor;
						print ("Tryckt på RÄTT knapp 5");
					} else {
						pan.color = UnityEngine.Color.red;
						print ("Tryckt på FEL knapp 5");
					}
				}

				if (iet == 5) {
					if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == d) {
						pan.color = d.colors.normalColor;
						print ("Tryckt på RÄTT knapp 6");
						DisableButtons ();
					} else {
						pan.color = UnityEngine.Color.red;
						print ("Tryckt på FEL knapp 6");
						DisableButtons ();
					}
				}				
				iet += 1;
			} else {
				DisableButtons ();
			}
		}

	}
	void DisableButtons(){
		c.enabled = false;
		g.enabled = false;
		a.enabled = false;
		f.enabled = false;
		e.enabled = false;
		d.enabled = false;
	}

	public void PlaySong(){
		AudioSource audio = GetComponent<AudioSource>();
		audio.clip = sounds[theChoise-1];
		audio.Play();
	}

	public void TonesChoise(){
		print ("Tryckt på tonvalet");
		if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == choise1) {
			theChoise = 1;
			c.enabled = true;
			g.enabled = true;
			a.enabled = false;
			f.enabled = false;
			e.enabled = false;
			d.enabled = false;

			panel1.enabled = true;
			panel2.enabled = true;
			panel3.enabled = false;
			panel4.enabled = false;
			panel5.enabled = false;
			panel6.enabled = false;
			toneButtons ();
			print ("Tonval 1");
		}
		if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == choise2) {
			theChoise = 2;
			c.enabled = true;
			g.enabled = true;
			a.enabled = true;
			f.enabled = false;
			e.enabled = false;
			d.enabled = false;

			panel1.enabled = true;
			panel2.enabled = true;
			panel3.enabled = true;
			panel4.enabled = false;
			panel5.enabled = false;
			panel6.enabled = false;
			toneButtons ();
			print ("Tonval 2");

		}
		if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == choise3) {
			theChoise = 3;
			c.enabled = true;
			g.enabled = true;
			a.enabled = true;
			f.enabled = true;
			e.enabled = false;
			d.enabled = false;

			panel1.enabled = true;
			panel2.enabled = true;
			panel3.enabled = true;
			panel4.enabled = true;
			panel5.enabled = false;
			panel6.enabled = false;
			toneButtons ();
			print ("Tonval 3");
		
		}
		if (EventSystem.current.currentSelectedGameObject.GetComponent<Button> () == choise4) {
			theChoise = 4;
			c.enabled = true;
			g.enabled = true;
			a.enabled = true;
			f.enabled = true;
			e.enabled = true;
			d.enabled = true;

			panel1.enabled = true;
			panel2.enabled = true;
			panel3.enabled = true;
			panel4.enabled = true;
			panel5.enabled = true;
			panel6.enabled = true;
			toneButtons ();
			print ("Tonval 4");
		}
	}

	void toneButtons(){
		choise1.enabled = false;
		choise2.enabled = false;
		choise3.enabled = false;
		choise4.enabled = false;
		print ("NU HAR DEN GÅTT IN HÄR");
	}

	public void Restart(){
		print ("OMSTART");
		c.enabled = false;
		g.enabled = false;
		a.enabled = false;
		f.enabled = false;
		e.enabled = false;
		d.enabled = false;

		panel1.enabled = false;
		panel2.enabled = false;
		panel3.enabled = false;
		panel4.enabled = false;
		panel5.enabled = false;
		panel6.enabled = false;



		for(int i = 0; i < panels.Count; i++){
			Color theColor = new Color();
			ColorUtility.TryParseHtmlString ("FFFFFF64", out theColor);
			panels [i].color = theColor;
			iet = 0;
			print(panels[i].color);
		}

		if(theChoise == 1){
			c.enabled = true;
			g.enabled = true;
			a.enabled = false;
			f.enabled = false;
			e.enabled = false;
			d.enabled = false;

			panel1.enabled = true;
			panel2.enabled = true;
			panel3.enabled = false;
			panel4.enabled = false;
			panel5.enabled = false;
			panel6.enabled = false;
			print ("Tonval 1");
		}
		if(theChoise == 2){
			c.enabled = true;
			g.enabled = true;
			a.enabled = true;
			f.enabled = false;
			e.enabled = false;
			d.enabled = false;

			panel1.enabled = true;
			panel2.enabled = true;
			panel3.enabled = true;
			panel4.enabled = false;
			panel5.enabled = false;
			panel6.enabled = false;
		}
		if(theChoise == 3){
			c.enabled = true;
			g.enabled = true;
			a.enabled = true;
			f.enabled = true;
			e.enabled = false;
			d.enabled = false;

			panel1.enabled = true;
			panel2.enabled = true;
			panel3.enabled = true;
			panel4.enabled = true;
			panel5.enabled = false;
			panel6.enabled = false;
		}
		if(theChoise == 4){
			c.enabled = true;
			g.enabled = true;
			a.enabled = true;
			f.enabled = true;
			e.enabled = true;
			d.enabled = true;

			panel1.enabled = true;
			panel2.enabled = true;
			panel3.enabled = true;
			panel4.enabled = true;
			panel5.enabled = true;
			panel6.enabled = true;
		}
	}

	public void MoreTones(){
		choise1.enabled = true;
		choise2.enabled = true;
		choise3.enabled = true;
		choise4.enabled = true;
		Restart ();
	}
}
	