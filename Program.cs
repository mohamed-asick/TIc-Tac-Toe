using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_project
{
    class Program
    {
        //making array and
        //by default i am providing 0-9 where no use of zero
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            static int player=1;//by default player 1 is set
        static int choice;//this holds the choice at which position is user want to mark

        //the flag variable checks who has won if it's value is 1 then some one has won the match
        //if -1 the match has draw if 0 then match is still running
        static int flag=0;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();//whenever loop will be again start then screen will be clear
                Console.WriteLine("player 1:X and player 2:O");
                Console.WriteLine("\n");
                if(player %2==0)//checking the chance of the player
                {
                    Console.WriteLine("player 2 chance");
                }
                else
                {
                    Console.WriteLine("player 1 chance");
                }
                Console.WriteLine("\n");
                board();//calling the board function
                choice=int.Parse(Console.ReadLine());//taking users choice
                //checking that position where user want to run is marked(with X or O)or not
                if(arr[choice]!='X'&&arr[choice]!='O')
                {
                    if(player %2==0)//if chance is of player 2 than mark O else mark X
                    {
                        arr[choice]='O';
                        player++;
                    }
                    else
                    {
                        arr[choice]='X';
                        player++;
                    }
                }
                else
                //if there is any position where user want to run
                    //and that is already marked then show message and load board again
                {
                    Console.WriteLine("sorry the row {0} is already marked with {1}",choice,arr[choice]);
                    Console.WriteLine("\n");
                    Console.WriteLine("please wait 2 second board is loading again.....");
                    
                   }
              
                flag = checkwin();//calling of check win
            }
            while(flag !=1&&flag !=-1);
            //this loop will be run until all cell of the grid is not marked
            //with X and O some players is not win
            Console.Clear();//clearing the console
            board();//getting filled board again
                if(flag==1)
                    //if flag value is 1 then someone has win or 
                    //means who played marked last time which has win
                {
                    Console.WriteLine("player {0} has won",(player % 2)+1);
                }
                else//if flag value is -1 the match will be draw and no one is winner
                {
                    Console.WriteLine("draw");
                }
            Console.ReadLine();
        }
        //board method which creates board
        private static void board()
        {
            Console.WriteLine("\t|\t|\t");
            Console.WriteLine("{0}\t|{1}\t|{2}\t",arr[1],arr[2],arr[3]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("\t|\t|\t");
            Console.WriteLine("{0}\t|{1}\t|{2}\t",arr[4],arr[5],arr[6]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("\t|\t|\t|");
            Console.WriteLine("{0}\t|{1}\t|{2}\t",arr[7],arr[8],arr[9]);
            Console.WriteLine("\t|\t|\t");
        }
        //checking that any player has won or not
       private static int checkwin()
        {
            #region horizontal winning condition
            //winning condition for first row
            if(arr[1]==arr[2]&&arr[2]==arr[3])
            {
             return 1;
            }
            //winning condition for second row
            else if(arr[4]==arr[5]&&arr[5]==arr[6])
            {
                return 1;
            }
            //winning condition for third row
            else if(arr[6]==arr[7]&&arr[7]==arr[8])
            {
                return 1;
            }
            #endregion

          #region vertical winning condition
            //winning condition for first column
            else if(arr[1]==arr[4]&&arr[4]==arr[7])
            {
                return 1;
            }
            //winning condition for second column
            else if(arr[2]==arr[5]&&arr[5]==arr[8])
            {
                return 1;
            }
            //winning condition for third column
            else if(arr[3]==arr[6]&&arr[6]==arr[9])
            {
                return 1;
            }

          #endregion

         #region diagonal winning condition
                else if(arr[1]==arr[5]&&arr[5]==arr[9])
                {
                    return 1;
                }
                else if(arr[3]==arr[5]&&arr[5]==arr[7])
            {
                    return 1;
                }
            #endregion

            #region checking for draw
            //if all the calls or values filled with X or O then any player has won the match
            else if(arr[1]!='1'&&arr[2]!='2'&&arr[3]!='3'&&arr[4]!='4'&&arr[5]!='5'&&arr[6]!='6'&&arr[7]!='7'&&arr[8]!='8'&&arr[9]!='9')

            {
                return -1;
            }
            #endregion
            else
            {
                return 0;


 


 









        }
    }
}
}