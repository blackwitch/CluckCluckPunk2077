using Platformer.Core;
using Platformer.Mechanics;
using UnityEngine;

namespace Platformer.Gameplay
{
    /// <summary>
    /// Fired when the player performs a Jump.
    /// </summary>
    /// <typeparam name="PlayerJumped"></typeparam>
    public class PlayerJumped : Simulation.Event<PlayerJumped>
    {
        public PlayerController player;

        public override void Execute()
        {
            Debug.Log("START JUMP");
            if (player.audioSource && player.jumpAudio)
                player.audioSource.PlayOneShot(player.jumpAudio);
        }
    }
}