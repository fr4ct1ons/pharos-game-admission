using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stats : MonoBehaviour
{
    [SerializeField] int maxHp;
    [SerializeField] TextMeshProUGUI hpText;

    int currentHp;

    private void Awake()
    {
        currentHp = maxHp;
    }

    private void Start()
    {
        if (hpText)
            hpText.SetText(currentHp.ToString() + "/" + maxHp.ToString());
    }

    public void DealDamage(int value, Vector3 knockback)
    {
        currentHp -= value;

        GetComponent<Rigidbody>().AddForce(knockback);

        if (currentHp <= 0)
            Die();
    }
    public void SetCurrentHp(int value)
    {
        currentHp = value;
        if (hpText)
            hpText.SetText(currentHp.ToString() + "/" + maxHp.ToString());
    }
    public int GetCurrentHp() { return currentHp; }
    
    private void Die()
    {
        Destroy(gameObject);
    }
}
