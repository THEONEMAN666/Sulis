
using UnityEngine;


[ExecuteInEditMode] // be�ll�t�s m�dban is lefusson

public class GridLocker : MonoBehaviour
{
       void Update()
    {

       Vector3 pos = transform.position;
        pos.x = Mathf.Round(pos.x);
        pos.y = Mathf.Round(pos.y);
        pos.z = Mathf.Round(pos.z);

        transform.position = pos;

    }
}
