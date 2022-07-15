using UnityEngine;

namespace RRRStudyProject
{
    public sealed class Player : Unit
    {
        readonly UserInput _userInput = new UserInput();

        private GameObject player;

        MainGame game;

        public void Start()
        {
            game = FindObjectOfType<MainGame>();
            player = gameObject;
            data = new UnitData("Player", 100, 5)
            {
                unitPosition = transform.position,
                unitRotation = transform.rotation
            };
            movement = new UnitMovement(player, data);
            game.interactiveObjects.AddExecuteObj(_userInput);
        }

        public override void Update()
        {
            movement.Move(_userInput);
        }
    }
}