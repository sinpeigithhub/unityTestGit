using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectManager : MonoBehaviour
{

	 public GameObject parts;
	 public AnimationCurve Line;
	 public AnimationCurve Z_Line;

	 float curvePosi_Z;
	 float curvePosi_Y;

	 Vector3 Line_posi;

	 bool hantei = true;

	 GameObject obj;

	 void Update()
	 {

		  StartCoroutine("popeffect");

	 }


	 IEnumerator popeffect()
	 {
		  while (hantei)
		  {
			   hantei = false;
			   Line_posi = new Vector3(0, curvePosi_Y, curvePosi_Z);

			   curvePosi_Z = Z_Line.Evaluate(Time.time);
			   curvePosi_Y = Line.Evaluate(Time.time);

			   obj = Instantiate(parts, Line_posi, Quaternion.identity);
			   obj.transform.parent = gameObject.transform;

			   yield return new WaitForSeconds(0.01f);
			   hantei = true;
		  }
	 }



}
