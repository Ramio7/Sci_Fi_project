using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RRRStudyProject
{
    public class DamageAgent : ITakeDamage, IDoDamage
    {
        private readonly GameObject _damageInitializer;

        public DamageAgent(GameObject damageInitializer)
        {
            _damageInitializer = damageInitializer;
        }

        public void Fire(float damage)
        {
            
        }

        public void Hit(float incomingDamage)
        {
            
        }
    }
}