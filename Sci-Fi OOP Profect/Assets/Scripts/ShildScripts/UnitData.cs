using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RRRStudyProject
{
    public struct UnitData
    {
        [Header("Обязательные поля")] 
        public string name;
        public float maxHealth;
        public float currentHealth;
        public float speed;
        public bool isDead;

        [Header("Автозаполняемые поля")]
        public int unitId;
        public SVector3 unitPosition;
        public SQuaternion unitRotation;

        public UnitData(string unitName, float unitMaxHealth, float unitSpeed)
        {
            name = unitName;
            maxHealth = unitMaxHealth;
            currentHealth = maxHealth;
            speed = unitSpeed;
            isDead = false;

            //Заглушки, реализовать присвоение после проектирования фабрики юнитов
            unitId = -1;
            unitPosition = new SVector3();
            unitRotation = new SQuaternion();
        }
    }
}