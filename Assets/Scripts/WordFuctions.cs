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

    #region crescent_moon
    public Transform crescentT;
    public Color crescentCamBG;
    public void crescent()
    {
        crescentT.gameObject.SetActive(true);
        Camera.main.backgroundColor = crescentCamBG;
    }
    public void night()
    {
        crescent();
    }
    public void moon()
    {
        crescent();
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
    #region clothes
    #region shirt
    public Transform shirtT;
    public void shirt()
    {
        shirtT.gameObject.SetActive(true);
    }
    public void tee()
    {
        shirt();
    }
    #endregion
    #region leggings
    public Transform leggingsT;
    public void leggings()
    {
        leggingsT.gameObject.SetActive(true);
    }
    public void pants()
    {
        leggings();
    }
    public void jeans()
    {
        leggings();
    }
    public void shorts()
    {
        leggings();
    }
    #endregion
    public void clothing()
    {
        shirt();
        leggings();
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
    #region note
    public Transform[] noteT;
    public Transform[] notesT;
    public Transform flatT;
    public AudioSource bgm;
    public void note()
    {
        bgm.mute = false;
        for (int i = 0; i < noteT.Length; i++)
        {
            noteT[i].gameObject.SetActive(true);
        }
    }
    public void notes()
    {
        bgm.mute = false;
        for (int i = 0; i < noteT.Length; i++)
        {
            notesT[i].gameObject.SetActive(true);
        }
    }
    public void sing()
    {
        note();
        notes();
    }
    public void song()
    {
        sing();
    }
    public void sound()
    {
        sing();
    }
    public void music()
    {
        sing();
    }
    public void mute()
    {
        bgm.mute = true;
    }
    public void silent()
    {
        mute();
    }
    public void silence()
    {
        mute();
    }
    public void quiet()
    {
        mute();
    }
    public void flat()
    {
        flatT.gameObject.SetActive(true);
    }
    #endregion
    #region elements
    #region gold
    public Transform[] goldT;
    public Color goldCamBG;
    public void gold()
    {
        Camera.main.backgroundColor = goldCamBG;
        for (int i = 0; i < goldT.Length; i++)
        {
            goldT[i].gameObject.SetActive(true);
        }
    }
    #endregion
    #region silver
    public Transform[] silverT;
    public Color silverCamBG;
    public void silver()
    {
        Camera.main.backgroundColor = silverCamBG;
        for (int i = 0; i < silverT.Length; i++)
        {
            silverT[i].gameObject.SetActive(true);
        }
    }
    #endregion
    #endregion
    #region underwear
    public Transform thongT;
    public void thong()
    {
        thongT.gameObject.SetActive(true);
    }
    public void panty()
    {
        thong();
    }
    public void panties()
    {
        thong();
    }
    public void underwear()
    {
        thong();
    }
    #endregion
    #region glasses
    public Transform glassesT;
    public void glasses()
    {
        glassesT.gameObject.SetActive(true);
    }
    public void lens()
    {
        glasses();
    }
    public void sight()
    {
        glasses();
    }
    public void eyewear()
    {
        glasses();
    }
    #endregion
    #region weapons
    #region swords
    public Transform[] swordT;
    public void sword()
    {
        for (int i = 0; i < swordT.Length; i++)
        {
            swordT[i].gameObject.SetActive(true);
        }
    }
    public void hilt()
    {
        sword();
    }
    #endregion
    #region bow
    public Transform[] bowT;
    public void bow()
    {
        for (int i = 0; i < bowT.Length; i++)
        {
            bowT[i].gameObject.SetActive(true);
        }      
    }
    #endregion
    #region gun
    public Transform[] gunT;
    public void gun()
    {
        for (int i = 0; i < gunT.Length; i++)
        {
            gunT[i].gameObject.SetActive(true);
        }
    }
    public void shoot()
    {
        gun();
        bow();
    }
    public void fire()
    {
        shoot();
    }
    public void rifle()
    {
        gun();
    }
    #endregion
    public void weapon()
    {
        sword();
        bow();
        gun();
    }
    public void weapons()
    {
        weapon();
    }
    #endregion
    #region school
    #region book
    public Transform bookT;
    public void book()
    {
        bookT.gameObject.SetActive(true);
    }
    public void read()
    {
        book();
    }
    public void story()
    {
        book();
    }
    #endregion
    #region pen
    public Transform penT;
    public void pen()
    {
        penT.gameObject.SetActive(true);
    }
    public void pens()
    {
        pen();
    }
    public void write()
    {
        pen();
    }
    public void pencil()
    {
        pen();
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
    public void school()
    {
        book();
        pen();
        ruler();
    }
    #endregion
    #region shell
    public Transform shellT;
    public void shell()
    {
        shellT.gameObject.SetActive(true);
    }
    public void snail()
    {
        shell();
    }
    public void sea()
    {
        shell();
    }
    #endregion
    #region fence
    public Transform fenceT;
    public void fence()
    {
        fenceT.gameObject.SetActive(true);
    }
    #endregion
    #region twig
    public Transform twigT;
    public void twig()
    {
        twigT.gameObject.SetActive(true);
    }
    public void branch()
    {
        twig();
    }
    public void leaf()
    {
        twig();
    }
    public void stick()
    {
        twig();
    }
    #endregion
    #region snake
    public Transform snakeT;
    public void snake()
    {
        snakeT.gameObject.SetActive(true);
    }
    #endregion
    #region magnet
    public Transform magnetT;
    public void magnet()
    {
        magnetT.gameObject.SetActive(true);
    }
    #endregion
    #region mail
    public Transform mailT;
    public void mail()
    {
        mailT.gameObject.SetActive(true);
    }
    public void envelope()
    {
        mail();
    }
    public void letter()
    {
        mail();
    }
    public void message()
    {
        mail();
    }
    #endregion
    #region math
    public Transform plusT;
    public Transform multiplyT;
    public Transform sumT;

    public void plus()
    {
        plusT.gameObject.SetActive(true);
    }
    public void add()
    {
        plus();
    }
    public void multiply()
    {
        multiplyT.gameObject.SetActive(true);
    }
    public void times()
    {
        multiply();
    }
    public void sum()
    {
        sumT.gameObject.SetActive(true);
    }
    public void total()
    {
        sum();
    }
    public void aggregate()
    {
        sum();
    }
    public void math()
    {
        plus();
        multiply();
        sum();
    }
    public void equation()
    {
        math();
    }
    public void calculate()
    {
        math();
    }
    #endregion
    #region hook
    public Transform hookT;
    public void hook()
    {
        hookT.gameObject.SetActive(true);
    }
    public void fishing()
    {
        hook();
    }
    #endregion
    #region crate
    public Transform crateT;
    public void crate()
    {
        crateT.gameObject.SetActive(true);
    }
    public void box()
    {
        crate();
    }
    public void container()
    {
        crate();
    }
    #endregion
    #region search
    public Transform magnifyingGlassT;
    public void search()
    {
        magnifyingGlassT.gameObject.SetActive(true);
    }
    public void find()
    {
        search();
    }
    public void magnification()
    {
        search();
    }
    public void magnify()
    {
        search();
    }
    public void zoom()
    {
        search();
    }
    #endregion
    #region cone
    public Transform coneT;
    public void cone()
    {
        coneT.gameObject.SetActive(true);
    }
    public void traffic()
    {
        cone();
    }
    #endregion
    #region tools
    #region hammer
    public Transform hammerT;
    public void hammer()
    {
        hammerT.gameObject.SetActive(true);
    }
    public void mallet()
    {
        hammer();
    }
    #endregion
    #region drill
    public Transform drillT;
    public void drill()
    {
        drillT.gameObject.SetActive(true);
    }
    #endregion
    public void tool()
    {
        hammer();
        drill();
    }
    public void tools()
    {
        tool();
    }
    #endregion
    #region win
    public Transform[] winText;
    public Color winCamBg;
    public void win()
    {
        Camera.main.backgroundColor = winCamBg;
        for (int i = 0; i < winText.Length; i++)
        {
            winText[i].gameObject.SetActive(true);
        }
    }
    public void victory()
    {
        win();
    }
    public void finish()
    {
        win();
    }
    public void end()
    {
        win();
    }
    #endregion
    #region lose
    public Transform[] loseText;
    public Color loseCamBg;
    public void lose()
    {
        Camera.main.backgroundColor = loseCamBg;
        for (int i = 0; i < loseText.Length; i++)
        {
            loseText[i].gameObject.SetActive(true);
        }
    }
    public void die()
    {
        lose();
    }
    public void dead()
    {
        lose();
    }
    public void suicide()
    {
        lose();
    }
    #endregion

}
