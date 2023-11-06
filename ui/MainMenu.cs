using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_tac_game
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void quit_buttton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            BoardMenu board = new BoardMenu();
            board.Show();
        }
    }
}