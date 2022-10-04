
using UnityEngine;

public class eletszinsav : MonoBehaviour
{
    [SerializeField, Min(2)] int szegmensek = 5;
    [SerializeField] Color colorA, colorB;
    [SerializeField] Vector3 pointA, pointB;


     void OnDrawGizmos()
    {
         for (int i = 0; i < szegmensek; i++)
        {
            float tColor = (float)i / (szegmensek - 1);
            Gizmos.color = Color.Lerp(colorA, colorB, tColor);

            Vector3 start = Vector3.Lerp(pointA, pointB, (float)i / szegmensek);
            Vector3 end = Vector3.Lerp(pointA, pointB, (float)(i+1) / szegmensek);

            Gizmos.DrawLine(start, end);
        }
        
    }
}
