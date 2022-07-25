using UnityEngine;

namespace RRRStudyProject
{
    public class UserInput : UnitCommandInput
    {
        public override void Update()
        {
            moveTowards = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            lookAt = new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);
        }
    }
}