
using UnityEngine;

public class MetodPractice : MonoBehaviour
{

    void Start()
    {
        {
            LogSpr(1, 5);
            {
                LogSpr(10, 20);
                {
                    LogSpr(3, 7);


                    float f1 = Power(0.2f, 5);
                    float f2 = Power(3f, 4);



                }
            }



        }
        void LogSpr(int start, int end)
        {
            for (int i = 1; i < 10; i++)
            {
                Debug.Log(i * i);

            }

        }

        float Power(float baseNumber, int exponent)
        {
            float number = 1;
            for (int i = 0; i < exponent; i++)
            {
                number = number * baseNumber;
            }
            return -number;
        }

        float Minimum(float a, float b)
        {
            if (a < b)

                return a;
            else
                return b;
        }


        float Maximum(float a, float b, float c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            if (b > c)
                return b;

            return c;
        }
    }
}
