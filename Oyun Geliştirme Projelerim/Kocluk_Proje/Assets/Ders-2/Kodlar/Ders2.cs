using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

public class Ders : MonoBehaviour
{
    // Tekli Yorum Sat�r�

    // KISAYOLLAR
    // CTRL + X = Sat�r Silme
    // CTRL + C = Sat�r Kopyalama
    // CTRL + V = Sat�r Yap��t�rma
    // CTRL + D = Sat�r �o�altma

    /*
     * TOPLU YORUM SATIRI
     */

    /*
     * int = tam say�
     * float = ondal�kl� say�
     * double = uzun ve ondal�kl� say�
     * string = metin
     * char = tek karakter
     * bool = true yada false - 0/1       ---->     javada boolean
     */

    // De�i�ken Tipi + De�i�ken �sim = Rakam/Say�/Metin/Karakter/��lem
    // T�r D�n���m�

    int a = 1;
    int b = 10;
    string c = "Yaz�l�m Ko�lu�u";
    char d = 'A';
    bool e = true;


    // BU ALAN SADECE TANIMLAMA YAPILMASI ���N KULLANILAB�L�N�R.

    /*
     * KAR�ILA�TIRMA OPERAT�RLER�
     * <
     * >
     * <=
     * >=
     * ==
     * !=
     */

    /*
     * ER���M BEL�RLEY�C�
     * Public
     * Private
     * Protected
     * */

    // Sadece bilinen de�i�kenler d���nda
    // oyunda kullan�lan bile�enler de de�i�ken olarak tan�mlanabilir.

    /*
    Text yaz�;
    Camera camera;
    Light light;
    VisualEffect efekt;
    */

    //System.out.println("Oyun Ba�lad�");  ---> Java
    //Console.WriteLine("Oyun Ba�lad�");   ---> C#
    //Debug.Log("Oyun Ba�lad�");           ---> Unity & C#

    // Time.deltaTime = Ge�en zaman� hesaplama
    // gameObject.SetActive(True/False)

    public Text helloWorld;
    public Text sayacText;

    public Image sayacResmi;

    public float sayac = 5;

    void Start()
    {
        helloWorld.text = "Merhaba D�nya!";


        Debug.Log("Oyun Ba�lad�-START");
    }


    void Update()
    {
        if (sayac > 0)
        {
            sayac -= Time.deltaTime;
            helloWorld.text = "Ders Ba�l�yor...";
            sayacText.text = TimeSpan.FromSeconds(sayac).ToString(@"mm\:ss");
        }
        else if (sayac <= 0)
        {
            sayac = 0;
            sayacResmi.gameObject.SetActive(false);
            sayacText.text = "Ders Ba�lad�!..";
            helloWorld.text = "Ders Ba�lad�!..";
        }
    }

}