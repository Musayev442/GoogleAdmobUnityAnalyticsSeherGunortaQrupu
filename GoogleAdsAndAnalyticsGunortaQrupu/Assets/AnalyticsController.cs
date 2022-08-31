using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;


public class AnalyticsController : MonoBehaviour
{

	private int scoreValue;

	public int ScoreValue { get => scoreValue; set => scoreValue = value; }

	public void OnStartButtonClicked()
	{
		AnalyticsResult buttonClickResult = Analytics.CustomEvent("StartButtonClickedEvent");

		print("Result of event: " + buttonClickResult);
	}

	public void OnColorButtonPressed(string color)
	{

		Dictionary<string, object> eventData = new Dictionary<string, object>

		{
			{ "colorParam",color},
			{ "playTime",Time.realtimeSinceStartup}
		};


		AnalyticsResult colorButtonClickResult = Analytics.CustomEvent("OnColorButtonClickedEvent",eventData);

		print("Result of color: "+color+ " "+colorButtonClickResult +" "+ Time.realtimeSinceStartup);

	}
}
