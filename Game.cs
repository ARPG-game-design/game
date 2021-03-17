using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Game
{
    public static SaveData sav = new SaveData();
}

public class SaveData
{
    public float maxHp = 5f;
    public float hp = 5.0f;

    public float Damage(float dmg)
    {
        hp = Mathf.Clamp(hp - dmg, 0, maxHp);
        return hp;
    }
}