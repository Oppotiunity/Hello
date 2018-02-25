using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 输入测试
public class InputTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
/* //		鼠标按下
		if (Input.GetMouseButtonDown  (0)) {
			print ("down");
			Debug.Log (Input.mousePosition);   //显示鼠标的位置
		}
		if (Input.GetMouseButtonUp (0)) {
			print ("Up");
		}
		if (Input.GetMouseButton (0)) {
			print ("*****");
		}*/



		/*//按下键盘的某个键   KeyCode.B可以改成任意的小写字母

		if (Input.GetKeyDown (KeyCode.B)) {
			print ("B按下");
		}
		if (Input.GetKeyUp (KeyCode.B)) {
			print ("B键起来");
		}
		if (Input.GetKey (KeyCode.B)) {
			print ("****");
		}*/


		//任意键
//		if (Input.anyKey) {
//			print ("任意键");
//		}

		/*if (Input.anyKeyDown) {
			print ("任意键被按下！");
		}*/

		float x=Input.GetAxis ("Horizontal");
		print (x);
		this.transform.Rotate (0,x,0);
		float y = Input.GetAxis ("Vertical");
		print (y);
		this.transform.Translate (0,y*Time.deltaTime,0);
	}
}
