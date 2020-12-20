using System;
using System.Collections.Generic;

// The board for the NumberTile game  
public class Board
{
    private ArrayList<NumberTile> board ;    // the board for a NumberTile game

    // Creates a new Board containing a single NumberTile

    public Board()
    {
       // TO DO: Code the body of this method       
    }

    // Return the NumberTile at the specified index on this Board
    public NumberTile getTile (int index)
    {
       // TO DO: Code the body of this method
       
       // temporary return statement so program skeleton will compile and run
       return null ;   
    }
    
    // Return the current number of tiles on this Board
    public int getSize()
    {
       // TO DO: Code the body of this method
       
       // temporary return statement so program skeleton will compile and run
       return -999 ;
    }
    
    // Insert a new tile into this Board at the specified index
    public void addTile(int index, NumberTile tile)
    {
       // TO DO: Code the body of this method
    }
    
    // Return a multiline string containing all the tiles on this Board
    public string ToString()
    {
       // TO DO: Code the body of this method
       
       // temporary return statement so program skeleton will compile and run
       return "The board" ;
    }           
}