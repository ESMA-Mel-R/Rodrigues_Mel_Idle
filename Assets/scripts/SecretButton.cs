using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretButton : MonoBehaviour
{
    public Autoclick Ac;
    public PaymentManagement Pm;
    private bool active;

    void Start()
    {
        active = false;
    }

    void Update()
    {
        if (active)
        {
            Ac._gain = Ac._gain * 2;
        }
    }
}
