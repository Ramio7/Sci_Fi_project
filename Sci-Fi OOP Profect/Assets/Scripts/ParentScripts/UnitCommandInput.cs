using UnityEngine;

namespace RRRStudyProject
{
    public abstract class UnitCommandInput : IExecute
    {
        public Vector3 moveTowards;
        public Vector3 lookAt;

        protected UnitData unitData;

        public abstract void Update();
    }
}