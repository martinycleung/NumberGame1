using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class GameController : MonoBehaviour {
	int mark;
	int answer;
	int correct_answer;
	public Text mathtext;
	public Text anstext;
	public Text marktext;
	public Text statustext;
	IEnumerator checkresult() {
		if (answer==correct_answer) { 
			mark++; 
			statustext.text="Great! This is correct!";
		}
		else {
			statustext.text="Correct answer is "+correct_answer.ToString();
		}
		Debug.Log ("Current mark:" + mark.ToString());
		marktext.text = mark.ToString();
		yield return new WaitForSeconds(2);
		Debug.Log ("Wait for 1 sec");

		clearanswer();
		GenerateQuestion();

	}

	void clearanswer() {
		answer = 0;
		anstext.text=answer.ToString();
	}

	void removeonedigit() {
		answer = answer / 10;
		anstext.text=answer.ToString();
	}

	void updatenumber(int digit) {
		if (answer == 0 && digit > 0 && answer < 10) {
			answer = digit;
		} else if (answer < 100) {
			answer = 10 * answer + digit;
		}
		anstext.text=answer.ToString();
	}

	// Use this for initialization
	void Start () {
		mark=0;
		answer=0;
		GenerateQuestion();
	}

	void GenerateQuestion() {
		System.Random rnd = new System.Random();
		int first;
		int second;
		string result="";
		//switch (rnd.Next(1,5)) {
		switch (1) {
			case 1:
			// addition
				first=rnd.Next(1,10);
				second=rnd.Next(1,10);
				result=string.Format("{0}+{1}", first ,second);
				correct_answer=first+second;
				break;
			case 2:
			// subtraction
				correct_answer=rnd.Next(1,10);
				second=rnd.Next(1,10);
				first=second+correct_answer;
				result=string.Format("{0}-{1}", first ,second);
				break;
			case 3:
			// multiplication
				first=rnd.Next(1,10);
				second=rnd.Next(1,10);
				result=string.Format("{0} \u00D7 {1}", first ,second);
				correct_answer=first*second;
				break;
			case 4:
			// division
				correct_answer=rnd.Next(1,10);
				second=rnd.Next(1,10);
				first=second*correct_answer;
				result=string.Format("{0} \u00F7 {1}", first ,second);
				break;
		}
		statustext.text = "";
		mathtext.text=result;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {  
			StartCoroutine(checkresult()); 
		}
		else if (Input.GetKeyDown(KeyCode.Backspace)) { removeonedigit(); }
		else if (Input.GetKeyDown("0")) {  updatenumber(0); }
		else if (Input.GetKeyDown("1")) {  updatenumber(1); }
		else if (Input.GetKeyDown("2")) {  updatenumber(2); }
		else if (Input.GetKeyDown("3")) {  updatenumber(3); }
		else if (Input.GetKeyDown("4")) {  updatenumber(4); }
		else if (Input.GetKeyDown("5")) {  updatenumber(5); }
		else if (Input.GetKeyDown("6")) {  updatenumber(6); }
		else if (Input.GetKeyDown("7")) {  updatenumber(7); }
		else if (Input.GetKeyDown("8")) {  updatenumber(8); }
		else if (Input.GetKeyDown("9")) {  updatenumber(9); }

	}

	
}
