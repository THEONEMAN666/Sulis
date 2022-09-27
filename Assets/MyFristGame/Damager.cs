
using UnityEngine;

public class Damager : MonoBehaviour

{
      [SerializeField] int damage;
     void OnTriggerEnter(Collider other) 

    {
        Damageble damageble = other.GetComponent<Damageble>();    //Damageble komponens lek�rdez�se

        if (damageble != null)
        {
            damageble.Damage(damage);

        }



    }
}
