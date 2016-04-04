using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class ReadAnimalTraitForm : Form
    {
        private const string LABEL_MESSAGE = "A {0} _______ but a {1} does not (Fill it with an animal trait, like 'lives in water').";

        public ReadAnimalTraitForm(String playerAnimal, String guessedAnimal)
        {
            InitializeComponent();
            label.Text = String.Format(LABEL_MESSAGE, playerAnimal, guessedAnimal);
            Text = Game.GAME_NAME;
        }

        public String getAnimalTrait()
        {
            return animalTraitTextBox.Text;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void animalTraitTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Close();
            }
        }
    }
}
