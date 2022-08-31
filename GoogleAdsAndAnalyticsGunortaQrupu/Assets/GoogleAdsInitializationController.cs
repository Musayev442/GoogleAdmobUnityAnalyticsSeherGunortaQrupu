using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class GoogleAdsInitializationController : MonoBehaviour
{
	private void Awake()
	{
		MobileAds.Initialize(initState=> { });
	}

}
