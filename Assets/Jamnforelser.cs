using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jamnforelser : MonoBehaviour
{

    public int userValue;
    public int Point = 10;
    public int PointAdd;
    public int PointDec;
    public int DragonLife = (Random.Range(100, 151));
    public int PlayerLife = 100;
    public int DragonHit;
    public int PlayerDamage;
    public int DragonDamage;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print(userValue += 2);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print(userValue /= 2);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }

        Uppgift2();
        Uppgift3();

    }
    void Uppgift2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PointAdd = Random.Range(1, 6 + 1);
            print(string.Format("PointAdd rolled a {0}", PointAdd));
            PointDec = Random.Range(1, 6 + 1);
            print(string.Format("PointDec rolled a {0}", PointDec));

            print(Point += PointAdd);
            print(Point -= PointDec);

            print(string.Format("Your point is now {0}"
                , (Point)));
        }
        if (Point >= 20)
        {
            print("You Win");
        }
        else if (Point <= 0)
        {
            print("You Lose");
        }
    }

    void Uppgift3()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            DragonHit = Random.Range(0, 2);
            if (DragonHit == 1)
            {
                DragonDamage = Random.Range(20, 25);
                print(string.Format("The Dragon did {0} damage", DragonDamage));
                print(PlayerLife -= DragonDamage);
                PlayerDamage = Random.Range(5, 25);
                print(string.Format("PlayerDamage did {0} damage", PlayerDamage));
                print(DragonLife -= PlayerDamage);
            }
            else if (DragonHit == 0)
            {
                PlayerDamage = Random.Range(5, 25);
                print(string.Format("The Player did {0} damage", PlayerDamage));
                print(DragonLife -= PlayerDamage);

            }
            if (PlayerLife <= 0)
            {
                print(string.Format("The dragon wins"));
            }
            if(DragonLife <= 0)
            {
                print(string.Format("The player wins"));
            }
        }
    }
}
