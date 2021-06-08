using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    // دو متغیر زیر مقدار خرید ماسک را در خود ذخیره می کنند
    public Button MaskItem_10;
    public GameObject MaskItem_10_Tireh;

    public Button MaskItem_30;
    public GameObject MaskItem_30_Tireh;

    public Button ZofoniItem_50;
    public GameObject ZofoniItem_50_Tireh;

    public Button ZofoniItem_70;
    public GameObject ZofoniItem_70_Tireh;

    public Text Mask;
    public Text Zofoni;
    public Text CoinNumber;
    //منظور از نامبر تیره، تعداد یک آیتم در فروشگاه است
    public string NumberTireh;

    void Start()
    {
        MaskItem_10.onClick.AddListener(() =>
        {
            Mask.text = "10";
            //string MaskStr = Convert.ToString(Mask.text);
            //int MaskAsli = (int)Convert.ToInt64(MaskStr);
            File.WriteAllText(Application.persistentDataPath + "Mask.lvl", Mask.text);
            NumberTireh = "10";
            PlayerPrefs.SetString(NumberTireh, "on");
            MaskItem_10_Tireh.SetActive(true);
            int Coin = PlayerPrefs.GetInt("Coin");
            if (Coin == 0)
            {
                CoinNumber.text = "0";
                //هیچ چیز!
            }
            else
            {
                int CoinFinally = Coin - 10;
                CoinNumber.text = Convert.ToString(CoinFinally);
            }
        });

        MaskItem_30.onClick.AddListener(() =>
        {
            Mask.text = "30";
            //string MaskStr = Convert.ToString(Mask.text);
            //int MaskAsli = (int)Convert.ToInt64(MaskStr);
            File.WriteAllText(Application.persistentDataPath + "Mask.lvl", Mask.text);
            NumberTireh = "30";
            PlayerPrefs.SetString(NumberTireh, "on");
            MaskItem_30_Tireh.SetActive(true);
            int Coin = PlayerPrefs.GetInt("Coin");
            if (Coin == 0)
            {
                CoinNumber.text = "0";
                //هیچ چیز!
            }
            else
            {
                int CoinFinally = Coin - 30;
                CoinNumber.text = Convert.ToString(CoinFinally);
            }
        });

        ZofoniItem_50.onClick.AddListener(() =>
        {
            Zofoni.text = "50";
            //string ZofoniStr = Convert.ToString(Zofoni.text);
            //int ZofoniAsli = (int)Convert.ToInt64(ZofoniStr);
            File.WriteAllText(Application.persistentDataPath + "Zofoni.lvl", Zofoni.text);
            NumberTireh = "50";
            PlayerPrefs.SetString(NumberTireh, "on");
            ZofoniItem_50_Tireh.SetActive(true);
            int Coin = PlayerPrefs.GetInt("Coin");
            if (Coin == 0)
            {
                CoinNumber.text = "0";
                //هیچ چیز!
            }
            else
            {
                int CoinFinally = Coin - 50;
                CoinNumber.text = Convert.ToString(CoinFinally);
            }
        });

        ZofoniItem_70.onClick.AddListener(() =>
        {
            Zofoni.text = "70";
            //string ZofoniStr = Convert.ToString(Zofoni.text);
            //int ZofoniAsli = (int)Convert.ToInt64(ZofoniStr);
            File.WriteAllText(Application.persistentDataPath + "Zofoni.lvl", Zofoni.text);
            NumberTireh = "70";
            PlayerPrefs.SetString(NumberTireh, "on");
            ZofoniItem_70_Tireh.SetActive(true);
            int Coin = PlayerPrefs.GetInt("Coin");
            if (Coin == 0)
            {
                CoinNumber.text = "0";
                //هیچ چیز!
            }
            else
            {
                int CoinFinally = Coin - 70;
                CoinNumber.text = Convert.ToString(CoinFinally);
            }
        });

        if (PlayerPrefs.GetString("10") == "on")
        {
            MaskItem_10_Tireh.SetActive(true);
        }

        if (PlayerPrefs.GetString("30") == "on")
        {
            MaskItem_30_Tireh.SetActive(true);
        }

        if (PlayerPrefs.GetString("50") == "on")
        {
            ZofoniItem_50_Tireh.SetActive(true);
        }

        if (PlayerPrefs.GetString("70") == "on")
        {
            ZofoniItem_70_Tireh.SetActive(true);
        }
    }
}
