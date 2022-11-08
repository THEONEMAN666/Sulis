using UnityEngine;
using TMPro;
using System.Collections;

public class Damageble : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] TMP_Text healthText;
    [SerializeField] Behaviour behaviour;

    [SerializeField] float _invicibleFrames = 1;

   // float _invicibleStarted;

    bool _isInvicible = false;

    int startHealth;

    void Start()
    {
        startHealth = health;
        health = PlayerPrefs.GetInt("health", health);
        UpdateText();
       
    }

    public bool IsAlive()

    {
        return health > 0;
    }
     /*
     void Update()
    {
        if (_isInvicible)

        if (Time.time > _invicibleStarted + _invicibleFrames)
        {
            _isInvicible = false;
        }

    }
         */
    public void Damage(int damage)
    {
       if (_isInvicible)
        {
         
            return;
        }
        
        health -= damage;

        // _invicibleStarted = Time.time;

        PlayerPrefs.SetInt("health", startHealth); // Mentés (életpontok)

        StartCoroutine(InvicibilityCoroutine());

        

        if (health < 0)
            health = 0;

        if (health == 0)
        {
           behaviour.enabled = false;
           PlayerPrefs.SetInt("health", startHealth);
        }
           

        UpdateText();

        
       
    }

    IEnumerator InvicibilityCoroutine()
    {
        const float flickTime = 0.1f;

        _isInvicible = true;

        bool _visible = false;
        for (int i =0; i < _invicibleFrames / flickTime; i++)
        {
            _Setvisibility(_visible);

            _visible = !_visible;

            yield return new WaitForSeconds(flickTime);
        }
        _Setvisibility(true);

        _isInvicible = false;
    }

    void _Setvisibility(bool _isVisible)
    {
        MeshRenderer[] renderers = GetComponentsInChildren <MeshRenderer>();
        foreach (var renderer in renderers)
        {
            renderer.enabled = _isVisible;
        }    
    }

    void SetVisibility(bool _isVisible)
    {
        
    }

    void UpdateText()

    {
        if (healthText != null)
            healthText.text = "Health: " + health;

    }
}
