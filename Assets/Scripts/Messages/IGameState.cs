using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public interface IGameState : IEventSystemHandler {

	void GameStateEnterIdle();
	void GameStateEnterRunning();
	void GameStateEnterEnding();

}
