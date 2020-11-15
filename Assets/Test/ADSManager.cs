using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;




public class ADSManager : MonoBehaviour
{
    public static ADSManager instance;

    public InterstitialAd interstitialAd;
    public BannerView banner;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        //google profilini burda kur
        MobileAds.Initialize((InitializationStatus  statuss) =>
        {
          
        });
    }


    public AdRequest RequestAd()
    {
        return new AdRequest.Builder().AddKeyword("bank").AddExtra("color_bg", "000").Build();
    }

    public void DownloadIntertitalAd()
    {
        //string AdUnitID = "ca-app-pub-5953930746224526/6048105271";
        string AdUnitID = "ca-app-pub-3940256099942544/1033173712";

        interstitialAd = new InterstitialAd(AdUnitID);

       interstitialAd.OnAdLoaded += OnInterstitalAdLoaded;
       

        interstitialAd.LoadAd(RequestAd());
        
    }
    public void ShowInterStitalAd()
    {
        if (!interstitialAd.IsLoaded()) return;
        interstitialAd.Show();
    }
    
    private void OnInterstitalAdLoaded(object sender,System.EventArgs e) 
    {
        Debug.Log("Reklam indirildi");

    }
    

}
