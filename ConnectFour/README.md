# Connect Four Game

A Blazor-based Connect Four game with move history tracking.

## Features

- **Classic Connect Four gameplay** - Drop pieces to connect 4 in a row
- **Move History** - Track and display all moves made during the game
- **Customizable colors** - Change board and player piece colors
- **Responsive design** - Works on desktop and mobile devices
- **Accessibility features** - Screen reader friendly move history

## New Feature: Move History

The game now includes a comprehensive move history system that:

- **Tracks every move** with player, column, row, and timestamp
- **Displays moves in real-time** as the game progresses
- **Shows column letters** (A-G) for easier reference
- **Color-codes moves** by player (red for Player 1, blue for Player 2)
- **Includes timestamps** for each move
- **Resets with the game** when starting a new game

### How to Use

1. Start a new game by clicking "Reset the game"
2. Click the dropdown arrows (🔽) to place pieces
3. Watch the move history update in real-time on the right side
4. Each move shows:
   - Turn number (circular badge)
   - Player indicator (colored)
   - Column letter and row number
   - Timestamp

### Technical Implementation

- **Move Class**: Stores player, column, row, turn number, and timestamp
- **GameState Enhancement**: Added `MoveHistory` list and move recording
- **MoveHistory Component**: Displays moves with responsive design
- **CSS Styling**: Modern, accessible styling with hover effects

## Running the Application

```bash
cd ConnectFour
dotnet run
```

Navigate to `https://localhost:5001` to play the game.

## Architecture

- **GameState.cs**: Core game logic and move tracking
- **Board.razor**: Main game interface with integrated move history
- **MoveHistory.razor**: Dedicated component for displaying moves
- **app.css**: Responsive styling for all components
