using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Deck
{
    public class Card : MonoBehaviour
    {

        public event Action<MonsterBehaviour> OnPlayed;

        private int cardIndex;
        private Player owner;
        private GameObject cardObject;

        private MonsterDC monsterData;

        public int Id => monsterData.Id;

        internal void Init(MonsterDC monsterDC, Player player)
        {
            owner = player;
            monsterData = monsterDC;
        }


        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.layer == LayerMask.NameToLayer("Tablero"))
            {
                StartCoroutine(Summon());
            }
        }

        private IEnumerator Summon()
        {
            yield return new WaitForSeconds( 0.25f);
            var newMonsterGameObject = Instantiate(monsterData.Prefab, transform.position,transform.rotation);
            var monsterBehaviour = newMonsterGameObject.GetComponent<MonsterBehaviour>();
            monsterBehaviour.Init(owner);
            if (OnPlayed != null)
            {
                OnPlayed.Invoke(monsterBehaviour);
                Debug.Log("A�adido");
            }
            Destroy(this.gameObject);
        }
    }
}