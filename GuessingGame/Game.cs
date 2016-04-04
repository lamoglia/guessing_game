
using System;
using GuessingGame.data;

namespace GuessingGame
{
    /// <summary>
    /// Main game logic.     
    /// Needs a concrete implementation with concrete presentation methods.
    /// </summary>
    public abstract class Game
    {
        public const string GAME_NAME = "Guessing Game";

        private Tree knowledgeTree;
        private TreeNode currentGuessingNode;
        
        public void startGame(string animalTrait, string animalWithTrait, string animalWithoutTrait)
        {
            //start the game with the initial guessings
            knowledgeTree = new Tree(animalTrait, animalWithTrait, animalWithoutTrait);

            while (askToThinkAboutAnAnimal())
            {
                askPlayerAboutTraits();
                String guessedAnimalName = currentGuessingNode.getData();

                //got an answer
                if (guessedItRight(guessedAnimalName))
                {
                    //I win, easy peasy
                    showWinMessage();
                }
                else
                {
                    //Bad luck, wrong guess...
                    //Get data from player and insert it in knowledge tree for the next round
                    improvGameWithPlayerAnimalData(guessedAnimalName);
                }
            }
        }

        private void askPlayerAboutTraits()
        {
            currentGuessingNode = knowledgeTree.getRootNode();
            while (!currentGuessingNode.isLeafNode())
            {
                String animalTrait = currentGuessingNode.getData();
                //another question
                if (playerAnimalHasTrait(animalTrait))
                {//take the "yes" branch
                    currentGuessingNode = currentGuessingNode.getYesNode();
                }
                else
                {//take the "no" branch
                    currentGuessingNode = currentGuessingNode.getNoNode();
                }
            }
        }

        private void improvGameWithPlayerAnimalData(string guessedAnimalName)
        {
            String playerAnimalName = askForAnimalName();
            String playerAnimalTrait = askForAnimalTrait(playerAnimalName, guessedAnimalName);

            currentGuessingNode.updateLeafNode(playerAnimalTrait, playerAnimalName);
        }

        abstract protected string askForAnimalTrait(string playerAnimalName, string guessedAnimalName);

        abstract protected string askForAnimalName();

        abstract protected void showWinMessage();

        abstract protected Boolean guessedItRight(string animal);

        abstract protected Boolean askToThinkAboutAnAnimal();

        abstract protected Boolean playerAnimalHasTrait(string trait);
    }
}
