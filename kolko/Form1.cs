namespace kolko
{
    enum CurrentPlayer
    {
        Cross,
        Circle
    }
    public partial class Form1 : Form
    {
        CurrentPlayer currentPlayer;
        public Form1()

        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.Cross;
            changeLabel();
        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (currentPlayer == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                currentPlayer = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "0";
                currentPlayer = CurrentPlayer.Cross;
            }
        }
        public void changeLabel()
        {
            if (currentPlayer == CurrentPlayer.Cross)
            {
                CurrentPlayerLabel.Text = "Krzy¿yk";
            }
            else
            {
                CurrentPlayerLabel.Text = "Kó³ko";
            }
        }
    }
}        
      