using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deck
{
    [CreateAssetMenu(fileName = "Monster", menuName = "ScriptableObjects/MonsterScriptableObject", order = 1)]
    public class MonsterDC : ScriptableObject
    {
        [SerializeField]
        private int id;
        [SerializeField]
        private string nombre;
        [SerializeField]
        private GameObject monster;
        [SerializeField]
        private int health = 10;
        [SerializeField]
        private int baseDamage = 5;

        private MonsterDC lockedMonster;

        public int Id => id;
        public MonsterDC LockedMonster => lockedMonster;
        public int BaseDmage => BaseDmage;
        public int Health =>health;
        public string Nombre=>nombre;
        public GameObject Prefab => monster;
        public void LockMonster(MonsterDC monster)
        {
            lockedMonster = monster;
        }
    }
}