using UnityEngine;

public class ControlStructesPractice : MonoBehaviour
{
    [SerializeField] int number;

    [SerializeField] string pairity;

    void Onvalidate()

    {
        pairity = "";

        bool isEven = number % 2 == 0;
        if (isEven)
        {
            pairity = "PAROS";
        }
        else
        {
            {
                pairity = "PARATLAN";

            }

            if (number < 0) ;


        }

    }
    private void Start()
    {
        int i = 1;
        while (i <= 10)

        {
            Debug.Log(i * i);

            // i = i + 1;
            // i += 1;
            i++;
        }


        for (int j = 10; j <= 1; j--)
        {
            Debug.Log(j);

        }
    }

}
