using System;
using System.Collections.Generic;

namespace Module3
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class ChessGame
    {
        private string state;

        public void StartNewGame()
        {
            state = "New Game Started!";
            Console.WriteLine(state);
        }

        public void MakeMove(string move)
        {
            state = $"Move made: {move}";
            Console.WriteLine(state);
        }

        public void UndoMove()
        {
            state = "Last move undone.";
            Console.WriteLine(state);
        }

        public string GetState() => state;
    }

    public class StartNewGameCommand : ICommand
    {
        private ChessGame game;

        public StartNewGameCommand(ChessGame game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.StartNewGame();
        }

        public void Undo()
        {
            Console.WriteLine("Cannot undo game creation.");
        }
    }

    public class MakeMoveCommand : ICommand
    {
        private ChessGame game;
        private string move;

        public MakeMoveCommand(ChessGame game, string move)
        {
            this.game = game;
            this.move = move;
        }

        public void Execute()
        {
            game.MakeMove(move);
        }

        public void Undo()
        {
            game.UndoMove();
        }
    }

    public class GameInvoker
    {
        private Stack<ICommand> commandHistory = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            commandHistory.Push(command);
        }

        public void UndoLastCommand()
        {
            if (commandHistory.Count > 0)
            {
                ICommand lastCommand = commandHistory.Pop();
                lastCommand.Undo();
            }
            else
            {
                Console.WriteLine("No commands to undo.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ChessGame game = new ChessGame();
            GameInvoker invoker = new GameInvoker();

            ICommand startNewGame = new StartNewGameCommand(game);
            invoker.ExecuteCommand(startNewGame);

            ICommand move1 = new MakeMoveCommand(game, "Pawn to E4");
            invoker.ExecuteCommand(move1);

            ICommand move2 = new MakeMoveCommand(game, "Knight to F3");
            invoker.ExecuteCommand(move2);

            invoker.UndoLastCommand();

            invoker.UndoLastCommand();
        }
    }
}
