using System.Collections;
using System.Collections.Generic;
using UnityEngine;




//Boss 
public class Boss{

	private int mp = 53;

	public void Magic(int usemp){
		if (this.mp > usemp) {


			this.mp -= usemp;
			Debug.Log ("「魔法攻撃をした。残りMPは" + this.mp + "。」");
		} else {
		
			Debug.Log ("「MPが足りないため魔法が使えない。」");
		
		}

	}


}


public class Test : MonoBehaviour {

	void InsideBox(){
	int[] box = { 10, 20, 30, 40, 50 };
		for(int i=0; i< box.Length; i++){
		Debug.Log(box[i]);
		}


		for(int i=box.Length - 1; i >= 0; i--){
			Debug.Log(box[i]);
		}

	}




	void Start () {

		InsideBox ();

		Boss witch = new Boss();
		witch.Magic (5);



		for (int i = 0; i < 10; i++){
			witch.Magic (5);

		}


	}
		
	void Update () {

	}
}
