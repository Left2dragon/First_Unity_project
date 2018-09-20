using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coding : MonoBehaviour
{
    //public = syns i unity.
    //int = heltal
    //float = decimaltal
    //double = dubbelt så många decimaltal
    //bool = ja eller nej
    //char = ett tecken
    //string = flera tecken
    //public int testInt;
    //public float testFloat;
    //public double testDouble;
    //public bool testBool;
    //public char testChar;
    //public string testString;
    public string Sentence1;
    public string Sentence2;
    public string Sentence3;
    public float Upphöjt;
    public float Kvadratrot;
    public float Trianglebase;
    public double Angle;
    public int pieces;
    public string username;
    public float radius;
    public int damage;
    public int life;
    public int demons;
    public int minDamage;

    

    // Use this for initialization
    void Start()
    {
        TestFunktion();
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
        Uppgift6();
        Uppgift7();
        Uppgift8();
    }


    // Update is called once per frame
    void Update()
    {

    }

    void TestFunktion ()
    {
        print("Article 13 är skit");
    }

    void Uppgift1()
    {
        print
            (string.Format(
                "Svaret på (963 * 421) - (175463 / 87) är {0}"
                , (963f * 421f) - (175463f / 87f)));
    }

    void Uppgift2()
    {
        print(string.Format("{0} {1} {2}", Sentence1, Sentence2, Sentence3));
    }

    void Uppgift3()
    {
        print(string.Format("Talet {0} upphöjt med 2 blir {1}", Upphöjt, (Mathf.Pow(Upphöjt,2))));
        print(string.Format("Kvadratroten ur talet {0} är {1}", Kvadratrot, (Mathf.Sqrt(Kvadratrot))));
    }

    void Uppgift4()
    {
        print(string.Format(
            "Höjden 8 gånger basen {0} blir arean {1}"
            , Trianglebase, (8 * Trianglebase / 2)));
    }

    void Uppgift5()
    {
        print(string.Format(
            "vinkeln {0} kan dela en tårta i {1} bitar"
            , Angle, (360f / Angle)));
        print(string.Format(
            "skär jag i {0} bitar har varje bit {1} graders vinkel "
            , pieces, (360f / pieces)));
    }

    void Uppgift6()
    {
        print(string.Format
            ("I am Boss {0} of Doom", username));
    }

    void Uppgift7()
    {
        print(string.Format("Har jag radien {0}cm med potensen 3 får jag {1}cm." +
            " Sedan multiplicerar jag {1} med 4 och då får jag {2} vilket man ska multipliceras sedan med pi och och till sist delar vi svaret med 3 och får volymen {3}cm^3"
            , radius, (Mathf.Pow(radius, 3)), (4 * (Mathf.Pow(radius, 3))), (((4 * (Mathf.Pow(radius, 3))) * 3.14f) / 3)));
    }

    void Uppgift8()
    {
        print(string.Format("The demon has 890000 health. With your strength, you need to attack {0} times in order to slay the demon"
            , (890000 / damage)));
        //(a
        print(string.Format("The demon has {0} health. With your strength, you need to attack {1} times in order to slay the demon"
            , life, (life / damage)));
        //(b
        print(string.Format("Suddenly {0} demons have apppeared, the demons have {1} health each. With your strength, you need to attack {2} times in order to slay all of the demons"
            , demons, life, ((demons * life) / damage)));
        //(c
        
    }
}
