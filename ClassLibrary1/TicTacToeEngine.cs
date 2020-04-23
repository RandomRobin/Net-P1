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
            // Vervangen door /n
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

            for (int i = 1; i < 10; i++)
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
                if (!getACell(cell).getText().Equals("X") && !getACell(cell).getText().Equals("O"))
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
                        //Invalid status
                        return false;
                    
                    }
                else
                {
                    //Not empty cell
                    return false;
                }



                //Checks if a player has won, by comparing the value of cells.

                if (((getACell(0).getText() == getACell(1).getText()) && (getACell(0).getText() == getACell(2).getText()) && (getACell(0).getText() != null))
                    || ((getACell(3).getText() == getACell(4).getText()) && (getACell(3).getText() == getACell(5).getText()) && (getACell(3).getText() != null))
                    || ((getACell(6).getText() == getACell(7).getText()) && (getACell(6).getText() == getACell(8).getText()) && (getACell(6).getText() != null))
                    || ((getACell(0).getText() == getACell(4).getText()) && (getACell(0).getText() == getACell(8).getText()) && (getACell(0).getText() != null))
                    || ((getACell(2).getText() == getACell(4).getText()) && (getACell(2).getText() == getACell(6).getText()) && (getACell(2).getText() != null))
                    || ((getACell(0).getText() == getACell(3).getText()) && (getACell(0).getText() == getACell(6).getText()) && (getACell(0).getText() != null))
                    || ((getACell(1).getText() == getACell(4).getText()) && (getACell(1).getText() == getACell(7).getText()) && (getACell(1).getText() != null))
                    || ((getACell(2).getText() == getACell(5).getText()) && (getACell(2).getText() == getACell(8).getText()) && (getACell(2).getText() != null)))
                {
                    if (this.status == GameStatus.PlayerXPlays)
                    {
                        setStatusPlayerXWins();
                        return true;

                    }

                    else if (this.status == GameStatus.PlayerOPlays)
                    {
                        setStatusPlayerOWins();
                        return true;
                    }
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

                //Checks if all cells has either a X or O
                foreach (Cell a in getCells())
                {
                    if (!(a.getText() == "X") && !(a.getText() == "O"))
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