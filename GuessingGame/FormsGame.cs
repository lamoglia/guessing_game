using System;

using System.Windows.Forms;

namespace GuessingGame
{
    /// <summary>
    /// Game presentation logic (Windows forms)
    /// </summary>
    public class FormsGame: Game
    {
        private const string THINK_ABOUT_AN_ANIMAL_MESSAGE = "Think about an animal...";
        private const string ASK_ABOUT_TRAIT_MESSAGE = "Does the animal that you thougth about {0}?";
        private const string REVEAL_GUESSED_ANIMAL_MESSAGE = "Is the animal you thougth about a {0}?";

        private const string I_WIN_MESSAGE = "I win again!";

        override protected string askForAnimalTrait(string playerAnimalName, string guessedAnimalName)
        {
            ReadAnimalTraitForm animalTraitForm = new ReadAnimalTraitForm(playerAnimalName, guessedAnimalName);
            animalTraitForm.ShowDialog();
            String animalTrait = animalTraitForm.getAnimalTrait();
            animalTraitForm.Dispose();

            return animalTrait;
        }

        override protected string askForAnimalName()
        {
            ReadAnimalNameForm animalNameForm = new ReadAnimalNameForm();
            animalNameForm.ShowDialog();
            String animalName = animalNameForm.getAnimalName();
            animalNameForm.Dispose();

            return animalName;
        }

        override protected void showWinMessage()
        {
            MessageBox.Show(I_WIN_MESSAGE, GAME_NAME, MessageBoxButtons.OK);
        }

        override protected Boolean guessedItRight(string animal)
        {
            String question = String.Format(REVEAL_GUESSED_ANIMAL_MESSAGE, animal);
            DialogResult dialogResult = MessageBox.Show(question, GAME_NAME, MessageBoxButtons.YesNo);
            return dialogResult == DialogResult.Yes;
        }

        override protected Boolean askToThinkAboutAnAnimal()
        {
            DialogResult dialogResult = MessageBox.Show(THINK_ABOUT_AN_ANIMAL_MESSAGE, GAME_NAME, MessageBoxButtons.OKCancel);
            return dialogResult == DialogResult.OK;
        }

        override protected Boolean playerAnimalHasTrait(string trait)
        {
            String question = String.Format(ASK_ABOUT_TRAIT_MESSAGE, trait);
            DialogResult dialogResult = MessageBox.Show(question, GAME_NAME, MessageBoxButtons.YesNo);
            return dialogResult == DialogResult.Yes;
        }
    }
}
