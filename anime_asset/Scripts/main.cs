using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {
	public Animator animator;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnGUI()
	{
		if(GUI.Button(new Rect(0, 0, 100, 50), "WALK")){
			animator.Play ("walk");
		}
		if(GUI.Button(new Rect(0, 100, 100, 50), "RUN")){
			animator.Play ("run");
		}
		if(GUI.Button(new Rect(0, 200, 100, 50), "ATTACK")){
			animator.Play ("attack");
		}
		if(GUI.Button(new Rect(0, 300, 100, 50), "IDLE")){
			animator.Play ("idle");
		}

	}
}
