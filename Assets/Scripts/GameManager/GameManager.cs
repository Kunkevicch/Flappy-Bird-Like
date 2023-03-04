using FBLG.Enums;
using FBLG.Misc;
using System;

namespace FBLG.General
{
    public class GameManager :SingletonMonobehaviour<GameManager>
    {

        public Action<GameState> GameStateChanged;

        private GameState _gameState;

        private GameState GameState
        {
            get { return _gameState; }
            set
            {
               _gameState = value;
                GameStateChanged?.Invoke(_gameState);
            }
        }

        protected override void Awake()
        {
            base.Awake();
        }

        private void Start()
        {
            StartGame();
        }

        public void StartGame()
        {
            GameState = GameState.MainMenu;
        }

    }

}