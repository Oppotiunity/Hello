using System.Collections;
using System.Collections.Generic;
using UnityEngine;
--------------------------------
public class materialText : MonoBehaviour {
	public GameObject cube;
	public GameObject spahere;
	public Transform sphere;
	// Use this for initialization
	void Start () {
//		使用GameObject对象.GetComponent<MeshRenderer> ().material.color = Color.green;为组件对象添加材质
		cube.GetComponent<MeshRenderer> ().material.color = Color.green;
		spahere.GetComponent<MeshRenderer> ().material.color = Color.red;

//		cube.transform.RotateAround (sphere.position,Vector3.up,1);
	}
	
	// Update is called once per frame
	void Update () {
//		表示cube围绕sphere旋转
		cube.transform.RotateAround (sphere.position,Vector3.up,1);
	}
}
