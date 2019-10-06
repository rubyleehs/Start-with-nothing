using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordFuctions : MonoBehaviour
{
    public static WordFuctions instance;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(this);
    }

    #region cresent_moon
    public Transform cresentT;
    public Color cresentCamBG;
    public void cresent()
    {
        cresentT.gameObject.SetActive(true);
        Camera.main.backgroundColor = cresentCamBG;
    }
    public void night()
    {
        cresent();
    }
    public void moon()
    {
        cresent();
    }
    #endregion
    #region gear
    public Transform gearT;
    public void gear()
    {
        gearT.gameObject.SetActive(true);
    }
    public void cog()
    {
        gear();
    }
    #endregion
    #region sun
    public Transform sunT;
    public Color sunCamBG;
    public void sun()
    {
        sunT.gameObject.SetActive(true);
        Camera.main.backgroundColor = sunCamBG;
    }
    public void noon()
    {
        sun();
    }
    public void solar()
    {
        sun();
    }
    public void day()
    {
        sun();
    }
    #endregion
    #region icon
    public Transform iconT;
    public void icon()
    {
        iconT.gameObject.SetActive(true);
    }
    public void info()
    {
        icon();
    }
    #endregion
    #region dollar
    public Transform dollarT;
    public void dollar()
    {
        dollarT.gameObject.SetActive(true);
    }
    public void coin()
    {
        dollar();
    }
    public void cash()
    {
        dollar();
    }
    public void money()
    {
        dollar();
    }
    #endregion
    #region ruler
    public Transform rulerT;
    public void ruler()
    {
        rulerT.gameObject.SetActive(true);
    }
    public void rule()
    {
        ruler();
    }
    public void inch()
    {
        ruler();
    }
    public void metre()
    {
        ruler();
    }
    public void meter()
    {
        ruler();
    }
    #endregion
    #region gun
    public Transform gunT;
    public void gun()
    {
        gunT.gameObject.SetActive(true);
    }
    public void shoot()
    {
        gun();
    }
    public void rifle()
    {
        gun();
    }
    #endregion
    #region crown
    public Transform crownT;
    public void crown()
    {
        crownT.gameObject.SetActive(true);
    }
    public void king()
    {
        crown();
    }
    public void royal()
    {
        crown();
    }
    #endregion
    #region thermometer
    public Transform thermometerT;
    public Color coldCamBG;
    public Color hotCamBG;
    public void cold()
    {
        thermometerT.gameObject.SetActive(true);
        Camera.main.backgroundColor = coldCamBG;
    }
    public void cool()
    {
        cold();
    }
    public void hot()
    {
        thermometerT.gameObject.SetActive(true);
        Camera.main.backgroundColor = hotCamBG;
    }
    public void heat()
    {
        hot();
    }
    #endregion
    #region shirt
    public Transform shirtT;
    public void shirt()
    {
        shirtT.gameObject.SetActive(true);
    }
    public void clothing()
    {
        shirt();
    }
    public void tee()
    {
        shirt();
    }
    #endregion
    #region guts
    public Transform gutsT;
    public Color gutsCamBG;
    public void guts()
    {
        gutsT.gameObject.SetActive(true);
        Camera.main.backgroundColor = gutsCamBG;
    }
    public void colon()
    {
        guts();
    }
    public void intestine()
    {
        guts();
    }
    public void entrail()
    {
        guts();
    }
    #endregion

    public void hint()
    {
        Debug.Log("ihint");//
    }
}
