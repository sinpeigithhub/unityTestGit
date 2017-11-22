using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effectManager : MonoBehaviour
{

	 public GameObject parts;

	 //この値でYの高さを調節（LifeLineよりも時間を長くすると変に見えるようになるので気を付けるように）
	 public AnimationCurve Line;

	 //この値で横の幅を調節（LifeLineよりも時間を長くすると変に見えるようになるので気を付けるように）
	 public AnimationCurve Z_Line;

	 float curvePosi_Z;
	 float curvePosi_Y;

	 //遅延させ多くインスタンスが生成されるのを制御しようと思ったが
	 //消滅させているのでそこまで多く作られることがないため、あまり必要ないかも
	 //ライフタイムの時間が長くなる時には調節が聞いていいかも
	 public float PopDilay_time;

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

			   yield return new WaitForSeconds(PopDilay_time);
			   hantei = true;
		  }
	 }



}
