using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class Ders : MonoBehaviour
{
    // Tekli Yorum Satýrý

    // KISAYOLLAR
    // CTRL + X = Satýr Silme
    // CTRL + C = Satýr Kopyalama
    // CTRL + V = Satýr Yapýþtýrma
    // CTRL + D = Satýr Çoðaltma

    /*
     * TOPLU YORUM SATIRI
     */

    /*
     * int = tam sayý
     * float = ondalýklý sayý
     * double = uzun ve ondalýklý sayý
     * string = metin
     * char = tek karakter
     * bool = true yada false - 0/1       ---->     javada boolean
     */

    // Deðiþken Tipi + Deðiþken Ýsim = Rakam/Sayý/Metin/Karakter/Ýþlem
    // Tür Dönüþümü

    int a = 1;
    int b = 10;
    string c = "Yazýlým Koçluðu";
    char d = 'A';
    bool e = true;


    // BU ALAN SADECE TANIMLAMA YAPILMASI ÝÇÝN KULLANILABÝLÝNÝR.

    /*
     * KARÞILAÞTIRMA OPERATÖRLERÝ
     * <
     * >
     * <=
     * >=
     * ==
     * !=
     */

    /*
     * ERÝÞÝM BELÝRLEYÝCÝ
     * Public
     * Private
     * Protected
     * */

    // Sadece bilinen deðiþkenler dýþýnda
    // oyunda kullanýlan bileþenler de deðiþken olarak tanýmlanabilir.

    /*
    Text yazý;
    Camera camera;
    Light light;
    VisualEffect efekt;
    */

    //System.out.println("Oyun Baþladý");  ---> Java
    //Console.WriteLine("Oyun Baþladý");   ---> C#
    //Debug.Log("Oyun Baþladý");           ---> Unity & C#

    // Time.deltaTime = Geçen zamaný hesaplama
    // gameObject.SetActive(True/False)

    public Text helloWorld;
    public Text sayacText;

    public Image sayacResmi;

    public float sayac = 5;

    void Start()
    {
        helloWorld.text = "Merhaba Dünya!";


        Debug.Log("Oyun Baþladý-START");
    }


    void Update()
    {
        if (sayac > 0)
        {
            sayac -= Time.deltaTime;
            helloWorld.text = "Ders Baþlýyor...";
            sayacText.text = TimeSpan.FromSeconds(sayac).ToString(@"mm\:ss");
        }
        else if (sayac <= 0)
        {
            sayac = 0;
            sayacResmi.gameObject.SetActive(false);
            sayacText.text = "Ders Baþladý!..";
            helloWorld.text = "Ders Baþladý!..";
        }
    }

}