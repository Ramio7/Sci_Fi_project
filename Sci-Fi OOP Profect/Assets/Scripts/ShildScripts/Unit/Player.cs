using UnityEngine;

namespace RRRStudyProject
{
    public sealed class Player : Unit
    {
        readonly UserInput _userInput = new UserInput();

        MainGame game;

        public void Start()
        {
            game = FindObjectOfType<MainGame>();
            data = new UnitData("Player", 100, 5)
            {
                unitId = gameObject.GetInstanceID(),
                unitPosition = transform.position,
                unitRotation = transform.rotation
            };
            movement = new UnitMovement(gameObject, data);
            game.interactiveObjects.AddExecuteObj(_userInput);
        }

        public override void Update()
        {
            movement.Move(_userInput);
        }
    }
}