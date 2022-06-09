using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Mancala_GUI
{
    public partial class Mancala : Form
    {
        public List<Panel> computerRow { get; set;}
        public List<Panel> playerRow {get; set;}
        private List<Label> playerLabels { get; set;}

        // Minimax variables
        public static readonly double MIN_VALUE = -1.0;
        public static readonly double MAX_VALUE = 1.0;

        // settings variables
        private int gameSetting = 0;
        private bool playerTurn = false;
        private bool randomizedColors = false;


        private Board board = new Board();

        private Random random = new Random();

        public Mancala()
        {               
            InitializeComponent();

            computerRow = new List<Panel>();
            playerRow = new List<Panel>();
            playerLabels = new List<Label>();

            OpponentDifficulty.SetSelected(1, true);
        }

        /// <summary>
        /// After clicking on settings, settings variables are set (pun not intended)
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The event</param>
        private void btnSelectSettings_Click(object sender, EventArgs e)
        {
            Settings.Visible = false;

            // player goes first setting
            if (playerGoesFirst.Checked)
            {
                playerTurn = true;
            }

            // use randomized colors setting
            if (randomizedMarbles.Checked)
            {
                randomizedColors = true;
            }

            // opponent difficulty level setting
            switch (OpponentDifficulty.SelectedIndex)
            {
                case 0:
                    gameSetting = 0; // easy 
                    break;
                case 2:
                    gameSetting = 2; // hard
                    break;
                default:
                    gameSetting = 1; // medium, default
                    break;
            }

            SetUpGame(); 

        }

        /// <summary>
        /// Method to set up and start the game
        /// </summary>
        private void SetUpGame()
        {
            background.Visible = true;


            FillRowsWithCups();

            FillCupsWithStones();

            StartGame();
        }

        /// <summary>
        /// Initialize Lists by adding cup panels to each respective row and spot labels to the player's spots
        /// </summary>
        private void FillRowsWithCups()
        {
            computerRow.Add(computer1);
            computerRow.Add(computer2);
            computerRow.Add(computer3);
            computerRow.Add(computer4);
            computerRow.Add(computer5);
            computerRow.Add(computer6);
            computerRow.Add(computerCup);

            playerRow.Add(player1);
            playerRow.Add(player2);
            playerRow.Add(player3);
            playerRow.Add(player4);
            playerRow.Add(player5);
            playerRow.Add(player6);
            playerRow.Add(playerCup);

            playerLabels.Add(spot1);
            playerLabels.Add(spot2);
            playerLabels.Add(spot3);
            playerLabels.Add(spot4);
            playerLabels.Add(spot5);
            playerLabels.Add(spot6);

        }

        /// <summary>
        /// Start game using player goes first setting
        /// </summary>
        private void StartGame()
        { 
            if (playerTurn)
            { 
                Thread.Sleep(100);
                if (!board.gameOver)
                {
                    PlayerMakeMove();
                }
            }
            else
            {
                Thread.Sleep(100);
                if (!board.gameOver)
                {
                    ComputerMakeMove();
                }
            }
        }

        /// <summary>
        /// Reset the current cups of marbles and fill with the new value of marbles from each cup 
        ///     (obtained from the board object's version of the row)
        /// </summary>
        private void FillCupsWithStones()
        {

            int center = 53;

            ResetAllCups(); 

            for (int i = 0; i < board.computerRow.Count; i++)
            {
                AddCurrNumMarblesInCupLabel(center, i, board.computerRow, computerRow);  

                for (int j = 0; j < board.computerRow[i]; j++)
                {
                    AddCirclesToCup(i, j, board.computerRow, computerRow);
                }

            }

            for (int i = 0; i < board.playerRow.Count; i++)
            {
                AddCurrNumMarblesInCupLabel(center, i, board.playerRow, playerRow);

                for (int j = 0; j < board.playerRow[i]; j++)
                {
                    AddCirclesToCup(i, j, board.playerRow, playerRow);  
                }

            }
        }

        /// <summary>
        /// Method to clear all current contents of computerRow and playerRow
        /// </summary>
        private void ResetAllCups()
        {
            foreach (Panel cupPanel in computerRow)
            {
                cupPanel.Controls.Clear();
                cupPanel.Refresh();

            }

            foreach (Panel cupPanel in playerRow)
            {
                cupPanel.Controls.Clear();
                cupPanel.Refresh();
            }
        }


        /// <summary>
        /// Method to add a label containing the current number of marbles in the specific cup to the cup
        /// </summary>
        /// <param name="center">The center of each of the cups</param>
        /// <param name="i">Current index of panel list for current player</param>
        /// <param name="currPlayer">Board row for the current player</param>
        /// <param name="currPlayerPanel">Panel row of the current player</param>
        private void AddCurrNumMarblesInCupLabel(int center, int i, List<int> currPlayer, List<Panel> currPlayerPanel)
        {
            Label label = new Label();
            label.Size = new Size(30, 15);

            label.Location = (i == 6) ? new Point(45, 125) : new Point(center, center);
            label.Text = currPlayer[i] + "";

            currPlayerPanel[i].Controls.Add(label);
            label.Refresh();
        }

        /// <summary>
        /// Method to add the marbles to each cup
        /// </summary>
        /// <param name="i">The index of the current player's panel row</param>
        /// <param name="j">The index of the player's board row contents (ranging from zero to the number of marbles in board)</param>
        /// <param name="currPlayer">The current player's board row</param>
        /// <param name="currPlayerPanel">The current player's panel row</param>
        private void AddCirclesToCup(int i, int j, List<int> currPlayer, List<Panel> currPlayerPanel)
        {
            Graphics graphics = currPlayerPanel[i].CreateGraphics();
            Thread.Sleep(5);
            Color color = randomizedColors ? GetRandomColor() : Color.SlateBlue;
            Pen pen = new Pen(color);
            SolidBrush brush = new SolidBrush(color);

            Point point;

            if (i == 6)
            {
                point = GetLocation(j, currPlayer[i], true);
            }
            else
            {
                point = GetLocation(j, currPlayer[i], false);
            }
            int currX = point.X;
            int currY = point.Y;
            graphics.DrawEllipse(pen, currX, currY, 20, 20);
            graphics.FillEllipse(brush, currX, currY, 20, 20);
        }


        /// <summary>
        /// Method to generate a random color (used if randomized color setting is turned on)
        /// </summary>
        /// <returns>Color object of random color</returns>
        private Color GetRandomColor()
        {
            KnownColor[] names = (KnownColor[]) Enum.GetValues(typeof(KnownColor));
            int randIndex = random.Next(names.Length);
            return Color.FromKnownColor(names[randIndex]);
          
        }

        /// <summary>
        /// Get the point of each marble
        /// </summary>
        /// <param name="index">The current marble's index</param>
        /// <param name="numMarbles">The total number of marbles in each cup</param>
        /// <param name="isMancala">Equation for the mancala cup is different, so has a bool value: is Mancala or not</param>
        /// <returns>A Point containing the x and y coordinates of the marble</returns>
        private Point GetLocation(int index, int numMarbles, bool isMancala)
        {
            int center = 53;
            int DistanceFromCenter = 30;


            double angle = 2.0 * Math.PI / numMarbles * index;
            int xCoord, yCoord;
            if (!isMancala)
            {
                xCoord = (int)Math.Floor(center + DistanceFromCenter * Math.Cos(angle));
                yCoord = (int)Math.Floor(center - DistanceFromCenter * Math.Sin(angle));
            }
            else
            {
                xCoord = (int) Math.Floor(46 + 30 * Math.Cos(angle));
                yCoord = (int) Math.Floor(117 + 90 * Math.Sin(angle));
            }
            Point point = new Point(xCoord, yCoord);
            return point;
        }

        
        /// <summary>
        /// Player make move method: 
        ///     * Sets playerTurn flag to true
        ///     * Shows the message telling user to choose a move
        ///     * Checks if game is over by seeing if there are any valid moves that the player can make
        /// </summary>
        private void PlayerMakeMove()
        {
            playerTurn = true;

            playerMessage.Visible = true;
            playerMessage.Refresh();

            List<int> allAvailableMoves = new List<int>();

            for (int spot = 0; spot < Board.NUM_SPOTS; spot++)
            {
                if (board.IsValidMove(Player.PLAYER, spot))
                {
                    allAvailableMoves.Add(spot);
                }
            }

            if (allAvailableMoves.Count == 0)
            {
                board.gameOver = true;

                DoWinningMove();
            }

        }

        /// <summary>
        /// Method getting the player's move based on which panel sent the MouseEvent
        /// </summary>
        /// <param name="sender">The player's cup panel which is calling the method by being clicked on</param>
        /// <param name="e">The MouseEvent</param>
        private void playerMove_MouseClick(object sender, MouseEventArgs e)
        {
            if (playerTurn)
            {
                int move;
                Panel panel = sender as Panel;
                if (panel == player1)
                    move = 0;
                else if (panel == player2)
                    move = 1;
                else if (panel == player3)
                    move = 2;
                else if (panel == player4)
                    move = 3;
                else if (panel == player5)
                    move = 4;
                else if (panel == player6)
                    move = 5;

                else move = 0; // default move is cup 1

                DoSomethingWithMove(move);
            }
        }


        /// <summary>
        /// Method getting the player's move based on which label sent the MouseEvent
        /// </summary>
        /// <param name="sender">The player's cup panel which is calling the method by being clicked on</param>
        /// <param name="e">The MouseEvent</param>
        private void spot_MouseClick(object sender, MouseEventArgs e)
        {
            if (playerTurn)
            {

                int move;
                Label label = sender as Label;
                if (label == spot1)
                    move = 0;
                else if (label == spot2)
                    move = 1;
                else if (label == spot3)
                    move = 2;
                else if (label == spot4)
                    move = 3;
                else if (label == spot5)
                    move = 4;
                else if (label == spot6)
                    move = 5;

                else move = 0; // default move is label 1
                DoSomethingWithMove(move);
            }
        }


        /// <summary>
        /// After getting the move, this "does something" with it: It makes the move and checks 
        ///     a) if there's a game over 
        ///     b) if player landed in Mancala
        /// Once making move, the reigns are handed over to the Computer to make its move
        /// </summary>
        /// <param name="move">The spot of the player's move</param>
        private void DoSomethingWithMove(int move)
        {
            bool madeMove = false;


            if (board.IsValidMove(Player.PLAYER, move) && !board.gameOver)
            {
                madeMove = true;

                MakeMove(Player.PLAYER, move);

                if (board.AllSpotsAreEmpty(Player.PLAYER))
                {
                    DoGameOverMoves(board.playerRow, board.computerRow); 
                }
                else if (board.AllSpotsAreEmpty(Player.COMPUTER))
                {
                    DoGameOverMoves(board.computerRow, board.playerRow);
                }
                else if (board.landedInMancala)
                {
                    board.landedInMancala = false;
                    madeMove = false;
                }

            }

            if (madeMove)
            {
                ReliquishControlToComputer(); 
            }
        }

        /// <summary>
        /// Method in which Player sets playerTurn flag to false and tells Computer to make its move
        /// </summary>
        private void ReliquishControlToComputer()
        {
            Thread.Sleep(5);
            playerTurn = false;
            playerMessage.Visible = false;
            playerMessage.Refresh();

            if (!board.gameOver)
            {
                Thread.Sleep(500);
                ComputerMakeMove();
            }
        }

        /// <summary>
        /// This method is the computer's turn: 
        ///     * It gets the move
        ///     * It makes the move
        ///     * It checks if it's game over
        ///     * It reliquishes control to Player
        /// </summary>
        private void ComputerMakeMove()
        {
            if (!playerTurn)
            {
                bool madeMove = true;
                int bestMove;
                bestMove = GetBestMove(); 

                if (bestMove == -1)
                {
                    board.gameOver = true;

                    DoWinningMove();
                }

                if (!board.gameOver)
                {
                    madeMove = ComputerDoActualMoveAndSeeResults(madeMove, bestMove);

                    if (madeMove && !board.gameOver)
                    {
                        ReliquishControlToPlayer(); 
                    }
                }
            }

            else
            {
                Thread.Sleep(100);
                PlayerMakeMove();
            }
        }

        /// <summary>
        /// Gets "best" computer move depending on opponent difficulty level setting
        /// </summary>
        /// <returns>int, the determined "best" move</returns>
        private int GetBestMove()
        {
            int bestMove;
            switch (gameSetting)
            {
                case 0:
                    bestMove = ComputerChooseFirstAvailableMove();
                    break;
                case 2:
                    bestMove = ComputerChooseMove();
                    break;
                default: // case 1, medium
                    bestMove = ComputerRandomlyChooseFirstAvailableMove();
                    break;
            }

            return bestMove;
        }

        /// <summary>
        /// Opponent difficulty level EASY: chooses first available move
        /// It is also the desperation move for opponent difficulty level HARD
        /// </summary>
        /// <returns>int, the first available move</returns>
        private int ComputerChooseFirstAvailableMove()
        {
            int currSpot = -1;
            for (int spot = 0; spot < Board.NUM_SPOTS; spot++)
            {
                if (board.IsValidMove(Player.COMPUTER, spot))
                {
                    currSpot = spot;
                    break;
                }
            }
            return currSpot;
        }

        /// <summary>
        /// Default opponent difficulty level MEDIUM: randomly chooses an available move
        /// </summary>
        /// <returns>int, randomly selected available move</returns>
        private int ComputerRandomlyChooseFirstAvailableMove()
        {
            int currSpot = -1;

            List<int> availableMoves = new List<int>();
            for (int spot = 0; spot < Board.NUM_SPOTS; spot++)
            {
                if (board.IsValidMove(Player.COMPUTER, spot))
                {
                    availableMoves.Add(spot);
                }
            }
            if (availableMoves.Count > 0)
            {
                int randomIndex = random.Next(availableMoves.Count);
                currSpot = availableMoves[randomIndex];
            }

            return currSpot;
        }

        /// <summary>
        /// Opponent difficulty level HARD: Chooses move based on Minimax (Game) Tree
        /// </summary>
        /// <returns>int, the best move</returns>
        private int ComputerChooseMove()
        {
            double highVal = -1.0;
            int bestMove = 0;


            Dictionary<Board, int> spotsAndChildren = board.GetPossibleNextBoardsAndTheSpotToCreateThem(Player.COMPUTER);

            foreach (Board possibleBoard in spotsAndChildren.Keys)
            {
                double thisVal;
                if (possibleBoard.landedInMancala)
                {
                    thisVal = GameTree.Value(possibleBoard, 4, Player.COMPUTER);
                }
                else
                {
                    thisVal = GameTree.Value(possibleBoard, 4 - 1, Player.PLAYER);
                }
                if (thisVal > highVal)
                {
                    bestMove = spotsAndChildren[possibleBoard];
                    highVal = thisVal;
                }
            }

            if (highVal == -1)
            {
                bestMove = ComputerChooseFirstAvailableMove(); // desperation move
            }

            return bestMove;
        }

        /// <summary>
        /// Internal method for the computer's actual move: 
        ///     * It updates its message label with its chosen move
        ///     * It makes the move
        ///     * It checks if it is now game over
        ///     * It checks if it has landed in Mancala
        /// </summary>
        /// <param name="madeMove">bool, has computer made move or not</param>
        /// <param name="bestMove">int, the computer's determined "best" move</param>
        /// <returns>bool, has the computer made its move or not</returns>
        private bool ComputerDoActualMoveAndSeeResults(bool madeMove, int bestMove)
        {
            computerMessage.Visible = true;
            computerMessage.Text = "Computer's Turn: Computer Chose " + (bestMove + 1);
            computerMessage.Refresh();

            MakeMove(Player.COMPUTER, bestMove);

            if (board.AllSpotsAreEmpty(Player.COMPUTER))
            {
                DoGameOverMoves(board.computerRow, board.playerRow);
            }
            else if (board.AllSpotsAreEmpty(Player.PLAYER))
            {
                DoGameOverMoves(board.playerRow, board.computerRow);
            }
            else if (board.landedInMancala)
            {
                board.landedInMancala = false;
                madeMove = false;
                ComputerMakeMove();
            }

            return madeMove;
        }

        /// <summary>
        /// Method in which Computer tells Player to make its move
        /// </summary>
        private void ReliquishControlToPlayer()
        {
            Thread.Sleep(5);
            computerMessage.Visible = false;
            computerMessage.Refresh();
            PlayerMakeMove();
        }

        /// <summary>
        /// Method to actually make the move and update board object with newBoard values
        /// </summary>
        /// <param name="player">Player enum (Player.PLAYER or Player.COMPUTER) actually making the move</param>
        /// <param name="move">int, the move</param>
        private void MakeMove(Player player, int move)
        {
            Board newBoard = board.MakeMove(player, move);
            board.computerRow = newBoard.computerRow;
            board.playerRow = newBoard.playerRow;
            board.landedInMancala = newBoard.landedInMancala;
            board.gameOver = newBoard.gameOver;

            FillCupsWithStones();
        }

        /// <summary>
        /// Method to set up Game Over
        /// </summary>
        /// <param name="currPlayer">The current player's board row</param>
        /// <param name="opposingPlayer">The opposing player's board row</param>
        private void DoGameOverMoves(List<int> currPlayer, List<int> opposingPlayer)
        {
            board.GameOverMove(currPlayer, opposingPlayer);
            FillCupsWithStones();
            DoWinningMove();
        }

        /// <summary>
        /// Show MessageBox containing the name of the winner
        /// </summary>
        private void DoWinningMove()
        {
            if (board.playerRow[6] == board.computerRow[6])
            {
                MessageBox.Show("Tie game!");
            }
            else
            {
                Player winner = (board.IsWinner(Player.PLAYER, board) ? Player.PLAYER : Player.COMPUTER);
                MessageBox.Show(winner + " won!");
            }

            computerMessage.Visible = false;
            computerMessage.Refresh();

            playerMessage.Visible = false;
            playerMessage.Refresh();
        }

        /// <summary>
        /// Show Instructions Form
        /// </summary>
        /// <param name="sender">The object sending the event</param>
        /// <param name="e">The event</param>
        private void button1_Click(object sender, EventArgs e)
        {
           Instructions instructions = new Instructions();
            instructions.Show();
        }

    }
}
