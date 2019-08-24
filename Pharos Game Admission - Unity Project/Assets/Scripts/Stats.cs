using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField] int maxHp;

    int currentHp;

    private void Awake()
    {
        currentHp = maxHp;
    }

    public void DealDamage(int value) { currentHp -= value; }
    public void SetCurrentHp(int value) { currentHp = value; }
    public int GetCurrentHp() { return currentHp; }

}
