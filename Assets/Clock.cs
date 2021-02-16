using System;
using UnityEngine;

public class Clock : MonoBehaviour {
	const float hoursToDegrees = -30, minutesToDegrees =-6f, secondstoDegress = -6f; 

	[SerializeField]
		Transform hoursPivot = default, minutesPivot, secondsPivot;
    void Update () {
		TimeSpan time = DateTime.Now.TimeOfDay;
		//Debug.Log (DateTime.Now.Hour); 
	       hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float) time.TotalHours); 
		   minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float) time.TotalMinutes);
		   secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondstoDegress * (float) time.TotalSeconds); 


	}
}