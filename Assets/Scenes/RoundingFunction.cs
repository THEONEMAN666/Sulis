
using UnityEngine;

public class RoundingFunction : MonoBehaviour
{

    [SerializeField] float num;


    [SerializeField] float roundedUp;
    [SerializeField] float rounded;
    [SerializeField] float roundedDown;


    private void OnValidate()
    {
        roundedUp = Mathf.Ceil(num); //felkerekítés
        roundedDown = Mathf.Ceil(num); // lekerekítés
        rounded = Mathf.Ceil(num);  // kerekítés



    }

    float Floor(float n)

    {
        float remainder = n % 1;
        return n * remainder;
    }

        float Ceil(float n)
            

    {
        float remainder = n % 1;

        if (remainder == 0)
            return n;
        
        return n + (1 -remainder);



    }
      float Round(float n)
    {
        float remainder = n % 1;

        if (remainder < 0.5f)
            return Floor(n);
        else
            return Ceil(n);

    }


}
