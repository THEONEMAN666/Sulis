using UnityEngine;

public class VectorPractice : MonoBehaviour
{


    void Onvalidate()

    {

        Vector2 vector = new Vector2(2, 5);

        float vx = vector.x;
        float vy = vector.y;

        vector.x = vy;
        vector.y = vx;

        Vector3 vector3 = new Vector3(1, 2, 4);
        vector3.z *= 2;

        Vector3 myUp = Vector3.up; // (0,1,0)
        Vector3 myLeft = Vector3.left; // (-1,0,0)

        Vector3 v1 = new Vector3(1, 6, 4), v2 = new Vector3(3, 7, 8);
        Vector3 v3 = new Vector3();
        float f1 = 3;

        Vector3 vSum = v1 + v2; // (4, 13, 12)
        Vector3 vSum2 = v1 + v3;

        Vector3 vProduct = v1 * f1; //( 3, 18, 12

        float m = vProduct.magnitude;
        Debug.Log(m);

        v1.Normalize();
        
        Vector3 n = v1.normalized;
        Debug.Log(n.magnitude);

        float d = (v1 - v2).magnitude;
        float d2 = Vector3.Distance(v1, v2);




    }

    
}
