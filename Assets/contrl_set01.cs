using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contrl_set01 : MonoBehaviour
{

	 //消滅スピード
	 public float Life_count = 0.4f;
	 Vector3 vector3;
	 float x = 1;
	 float y = 1;
	 
	 void Update()
	 {
		  x = gameObject.transform.localScale.x;
		  y = gameObject.transform.localScale.y;

		  vector3 = new Vector3(x, y, 1);

		  Life_count -= Time.deltaTime;
		  //x /= 3; 
		  //y /=3;

		  transform.localScale = vector3;

		  if (Life_count < 0)
		  {
			   Destroy(gameObject);
		  }
	 }
}
