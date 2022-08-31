using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class GoogleBannerController : MonoBehaviour
{
  [SerializeField] private string bannerAndroidId;

  [SerializeField] private string bannerIosId;

  private string currentBannerId;

  private BannerView bannerView;

	private void Start()
	{
#if UNITY_ANDROID
    currentBannerId = bannerAndroidId;
#elif UNITY_IOS
    currentBannerId = bannerIosId;
#endif

    bannerView = new BannerView(currentBannerId,AdSize.Banner,AdPosition.BottomRight);

    bannerView.OnAdClosed += OnAdClosed;

    bannerView.OnAdFailedToLoad += OnAdFailedToLoad;

    bannerView.OnAdLoaded += OnAdLoaded;

    bannerView.OnPaidEvent += OnPaidEvent;

		bannerView.OnAdOpening += OnAdOpening;

    AdRequest newRequest = new AdRequest.Builder().Build();

    bannerView.LoadAd(newRequest);

  }

	private void OnAdOpening(object sender, EventArgs e)
	{
		print("Ad opened");
	}

	private void OnPaidEvent(object sender, AdValueEventArgs e)
	{
		throw new NotImplementedException();
	}

	private void OnAdLoaded(object sender, EventArgs e)
	{
		print("Ad loaded");
	}

	private void OnAdFailedToLoad(object sender, AdFailedToLoadEventArgs e)
	{
		print("Ad failed to load");
	}

	private void OnAdClosed(object sender, EventArgs e)
	{
		print("Ad closed");
	}
}
