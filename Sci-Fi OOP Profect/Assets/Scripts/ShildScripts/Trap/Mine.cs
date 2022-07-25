using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RRRStudyProject
{
    public sealed class Mine : Trap
    {
        private void Start()
        {
            data = new TrapData("Mine", 1f, 3f)
            {
                trapId = gameObject.GetInstanceID(),
                trapPosition = transform.position,
                trapRotation = transform.rotation,
            };
        }

        public override void OnTriggerEnter(Collider other)
        {

        }
    }
}

