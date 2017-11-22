using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emitt_object : MonoBehaviour
{

	 //回転速度（この数値を上げることで、周りに同時に表示しいているように見せている）
	 public float rotateSpeed=0;
	 Vector3 vector3;

	 void Start()
	 {

	vector3= new Vector3(0, rotateSpeed, 0);

	 }

	 void Update()
	 {
		  transform.eulerAngles += vector3;
	}
}
