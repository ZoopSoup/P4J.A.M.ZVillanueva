using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public UnityEvent OnGunShoot;
    public float FireCooldown;


    public bool Automatic;

    private float CurrentCoolDown;
    // Start is called before the first frame update
    void Start()
    {
        CurrentCoolDown = FireCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (Automatic)
        {
            if (Input.GetMouseButton(0))
            {
                if (CurrentCoolDown <= 0f)
                {
                    OnGunShoot?.Invoke();
                    CurrentCoolDown = FireCooldown;
                }
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (CurrentCoolDown <= 0f)
                {
                    OnGunShoot?.Invoke();
                    CurrentCoolDown = FireCooldown;
                }
            }
        }

        CurrentCoolDown -= Time.deltaTime;
    }
}
