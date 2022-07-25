using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RRRStudyProject
{
    public struct TrapData
    {
        [Header("Обязательные поля")]
        public string name;
        public float damage;
        public float radiusOfFire;
        public bool isActive;

        [Header("Автозаполняемые поля")]
        public int trapId;
        public SVector3 trapPosition;
        public SQuaternion trapRotation;

        public TrapData(string trapName, float trapDamage, float trapRadiusOfFire)
        {
            name = trapName;
            damage = trapDamage;
            radiusOfFire = trapRadiusOfFire;
            isActive = true;

            //Заглушки, реализовать присвоение после проектирования фабрики объектов
            trapId = -1;
            trapPosition = new SVector3();
            trapRotation = new SQuaternion();
        }
    }
}