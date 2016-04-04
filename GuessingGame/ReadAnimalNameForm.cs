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
    public partial class ReadAnimalNameForm : Form
    {
        public ReadAnimalNameForm()
        {
            InitializeComponent();
            Text = Game.GAME_NAME;
        }

        public string getAnimalName()
        {
            return animalNameTextBox.Text;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void animalNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
            }
        }
    }
}
