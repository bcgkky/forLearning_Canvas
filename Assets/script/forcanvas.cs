using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class forcanvas : MonoBehaviour
{
    public Text minetext;
    public Image mineImage;
    public Slider mineSlider;
    public Scrollbar mineScrollbar;
    public Dropdown mineDrop;
    public InputField mineFıeld;
    public TextMeshProUGUI tttt;

    void Start()
    {
        minetext.text = "marhaba";
        //mineImage.fillAmount = .5f;

    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            mineImage.fillAmount -= .1f;
        }
        
    }

    public void candusur(float deger)
    {
        mineImage.fillAmount -= deger;
    }

    public void durumne(bool deger)
    {
        print(deger);
    }
    public void yazdir(string deger)
    {
        print(deger);
    }
    public void forslider()
    {
        Debug.Log(mineSlider.value);
    }
    public void forscrollbar()
    {
        Debug.Log(mineScrollbar.value);
    }

    public void fordrop(int deger)
    {
        Debug.Log("secilen değer = " + deger);
    }
    public void forfield()
    {
        Debug.Log(mineFıeld.text);
    }

}

