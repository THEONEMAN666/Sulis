using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolPractice : MonoBehaviour
{
         

    // Update is called once per frame
    void Update()
    {
        bool b1 = true;
        bool b12 = false;
        Debug.Log(b1);
        b1 = false;
        Debug.Log(b1);

        int i1 = 3, i2 = 7;

        bool b3 = i1 > i2;
        Debug.Log("i1 > i2:" + b3);                    // false

        // Nagyobb vagy egyenlo
        Debug.Log("i1 >= i2;" + (i1 >= i2));          // true


        bool b4 = i1 < i2;                            // false   
        bool b5 = i1 <= i2;                           // true


        // Egyenloseg vizsgalat                      
        bool b6 = i1 == 6;                            // false
        bool b7 = i2 != 7;                            // false


        string s1 = "frgs";

        bool b8 = s1 == "efer";                        // false
        bool b9 = s1 != "efer";                        // true


        bool b10 = b4 == b9;                           // false


        // Logikai muveletek
        // AND
        bool b11 = b1 && b7;

        // OR
        bool  b21 = b1 || b7;

        // XOR
        bool b13 = b1 ^ b7;

        // NOT
        bool b14 = !b1;



            
    }
}
