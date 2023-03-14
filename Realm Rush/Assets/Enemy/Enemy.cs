using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int goldReward = 25;
    [SerializeField] int goldPenalty = 25;

    Bank bank;

    void Awake()
    {
        bank = FindObjectOfType<Bank>();
    }

    public void RewardGold()
    {
        if (bank == null) { return; }

        bank.Deposite(goldReward);
    }
    public void StealGold()
    {
        if (bank == null) { return; }

        bank.Withdraw(goldPenalty);
    }
}
