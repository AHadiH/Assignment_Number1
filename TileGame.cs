using System;
using System.Collections.Generic;

// Implements a domino-like game where two players, both of whom are
// the computer, take turns inserting NumberTiles into a Board
public class TileGame
{
   // instance vars
   private Board board ;     // the game board
   private Hand hand1 ;      // Player 1 hand
   private Hand hand2 ;      // Player 2 hand
   private String winner ;   // the winner - player1, player2,
                             // or a tie game
   
   // Creates a new TileGame with two initial hands and a board
   public TileGame(Hand firstHand, Hand secondHand)
   {
      // TO DO: Code the body of this method
   }
   
   // Players take turn moving until one or both hand are empty
   public void play()
   {
      // TO DO: Code the body of this method
   }

   // Utility method called by method makeMove.  Returns the index at which a
   // new tile will be inserted into the board, or -1 if the tile cannot
   // be inserted.  The new tile may be inserted either (1) between two 
   // existing tiles, (2) as the new first tile, or (3) as the new last tile
   private int getIndexForFit(NumberTile tile)
   {
      // TO DO: Code the body of this method
       
      // temporary return statement so program skeleton will compile and run
      return -1 ;
   }

   // Utility method called by method play().  Checks consecutive tiles in the 
   // hand - by calling method getIndexForFit() - to see if one can be inserted 
   // into the board. When the first tile that fits is found, removes it from
   // the hand, inserts it into the board, and the move ends.  The tile may be
   // rotated up to 3 times. If none of the tiles fit, adds a new, random tile
   // to the hand  
   private void makeMove(Hand hand)
   {
      // TO DO: Code the body of this method
   }
   
   // Return results of the game as a humongous multi-line String containing
   // the final board, both both player's final hands, and the winner
   public String getResults()
   {
      // TO DO: Code the body of this method
      // HINT: call toString for the board and for each hand and don't
      //       forget the winner
       
      // temporary return statement so program skeleton will compile and run
      return "Results" ;
   }
} // end of TileGame2 class