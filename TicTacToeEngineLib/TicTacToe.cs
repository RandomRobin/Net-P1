using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicTacToeEngine
{
    public enum GameStatus { PlayerOPlays, PlayerXPlays, Equal, PlayerOWins, PlayerXWins }

    public class TicTacToe
    {
        private GameStatus status;
        private List<Cell> cells = new List<Cell>();

        public void setStatusPlayerOPlays()
        {
            this.status = GameStatus.PlayerOPlays;
        }

        public void setStatusPlayerXPlays()
        {
            this.status = GameStatus.PlayerXPlays;
        }

        public void setStatusEqual()
        {
            this.status = GameStatus.Equal;
        }
        public void setStatusPlayerOWins()
        {
            this.status = GameStatus.PlayerOWins;
        }

        public void setStatusPlayerXWins()
        {
            this.status = GameStatus.PlayerXWins;
        }

        public GameStatus getStatus()
        {
            return this.status;
        }

        public List<Cell> getCells()
        {
            return this.cells;
        }

        public void setCells(List<Cell> c)
        {
            this.cells = c;
        }

        public Cell getACell(int cell)
        {
            return this.cells[cell];
        }

        public String Board()
        {
            var board = "-------------" + Environment.NewLine +
     "| " + cells[0].getText() + " | " + cells[1].getText() + " | " + cells[2].getText() + " |" + Environment.NewLine +
     "-------------" + Environment.NewLine +
     "| " + cells[3].getText() + " | " + cells[4].getText() + " | " + cells[5].getText() + " |" + Environment.NewLine +
     "-------------" + Environment.NewLine +
     "| " + cells[6].getText() + " | " + cells[7].getText() + " | " + cells[8].getText() + " |" + Environment.NewLine +
     "-------------" + Environment.NewLine;
            return board;
        }

        public void Reset()
        {

            this.cells = new List<Cell>();

            for (int i = 1; i < 11; i++)
            {
                cells.Add(new Cell(i));
            }
            setStatusPlayerXPlays();
        }


        public Boolean ChooseCell(int cell)
        {

            //Checks if the choosen cells, is between 0-9 and the game status is valid.
            if ((cell >= 0 && cell < 9) && (status != GameStatus.Equal || status != GameStatus.PlayerOWins || status != GameStatus.PlayerXWins))
            {


                //Checks if the choosen cell is empty and if so, fills it with the correct players, otherwise returns false.
                if (!(getACell(cell).getText() == "X") || (getACell(cell).getText() == "Y"))
                    if (this.status == GameStatus.PlayerXPlays)
                    {
                        getACell(cell).setText("X");

                    }

                    else if (this.status == GameStatus.PlayerOPlays)
                    {
                        getACell(cell).setText("O");
                    }

                    else
                    {
                        return false;
                    }


                //Switches the turn of the player.
                if (this.status == GameStatus.PlayerXPlays)
                {
                    setStatusPlayerOPlays();

                }

                else if (this.status == GameStatus.PlayerOPlays)
                {
                    setStatusPlayerXPlays();
                }


                //Checks if a player has won

                if (((getACell(0).getText() == getACell(1).getText()) && (getACell(0).getText() == getACell(2).getText()) && (getACell(0).getText() == "X" || getACell(0).getText() == "O"))
                    || ((getACell(3).getText() == getACell(4).getText()) && (getACell(3).getText() == getACell(5).getText()) && (getACell(3).getText() == "X" || getACell(3).getText() == "O"))
                    || ((getACell(6).getText() == getACell(7).getText()) && (getACell(6).getText() == getACell(8).getText()) && (getACell(6).getText() == "X" || getACell(6).getText() == "O"))
                    || ((getACell(0).getText() == getACell(4).getText()) && (getACell(0).getText() == getACell(8).getText()) && (getACell(0).getText() == "X" || getACell(0).getText() == "O"))
                    || ((getACell(2).getText() == getACell(4).getText()) && (getACell(2).getText() == getACell(6).getText()) && (getACell(2).getText() == "X" || getACell(2).getText() == "O"))
                    || ((getACell(0).getText() == getACell(3).getText()) && (getACell(0).getText() == getACell(6).getText()) && (getACell(0).getText() == "X" || getACell(0).getText() == "O"))
                    || ((getACell(1).getText() == getACell(4).getText()) && (getACell(1).getText() == getACell(7).getText()) && (getACell(1).getText() == "X" || getACell(1).getText() == "O"))
                    || ((getACell(2).getText() == getACell(5).getText()) && (getACell(2).getText() == getACell(8).getText()) && (getACell(2).getText() == "X" || getACell(2).getText() == "O")))
                {
                    if (this.status == GameStatus.PlayerXPlays)
                    {
                        setStatusPlayerOWins();
                        return true;

                    }

                    else if (this.status == GameStatus.PlayerOPlays)
                    {
                        setStatusPlayerXWins();
                        return true;
                    }
                }

                //Checks if all cells has either a X or O

                foreach (Cell a in getCells())
                {
                    if (!(a.getText() == "X") || (a.getText() == "O"))
                    {
                        return true;
                    }
                }


                //"Jammer~! Niemand wint!"
                setStatusEqual();
                return true;

            }
            else
            {
                return false;
            }

        }


        public class Cell
        {
            private String text;
            private int code;

            public Cell(int code)
            {
                this.text = code.ToString();
                this.code = code;
            }

            public void setText(String text)
            {
                this.text = text;
            }
            public String getText()
            {
                return this.text;
            }

            public String getCode()
            {
                return this.code.ToString();
            }
        }
    }
}