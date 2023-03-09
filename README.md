# RedDoor-Interview NQueensSolver
![image](https://user-images.githubusercontent.com/13402112/224084745-8f509a13-493b-456d-aea8-90eecc6ade1e.png)

This is NQueensSolver that try solving the problem of placing N chess queens on an N×N chessboard so that no two queens threaten each other.
Using depth-first backtracking algorithm for getting solutions count and drawing the board graph.

For Binary review, please download from https://github.com/chile109/RedDoor-Interview/releases/tag/1.0

Double click `NQueensSolver.exe` file on MS windows OS (Already tested on Win11).

The following Instructions for Running, Building, and Testing the NQueensSolver Console App.

## Prerequisites
Before you begin, ensure that you have the following installed on your system:
- .NET SDK version 6.0 or higher
- A text editor or an integrated development environment (IDE) such as Visual Studio Code.

## Running the Console App
To run the C# Console App, follow these steps:

1. Clone the repository to your local machine by running the following command in your terminal:
``` bash
git clone https://github.com/chile109/RedDoor-Interview.git
```

2. Navigate to the directory containing the C# Console App source code:
```bash
cd RedDoor-Interview/NQueensSolver
```

3. Run the following command to run the application:
```bash
dotnet run
```

## Building the Console App
To build the NQueensSolver Console App, follow these steps:

1. Navigate to the directory containing the C# Console App source code
```bash
cd RedDoor-Interview/NQueensSolver
```

2. Run the following command to build the application:
This command compiles the source code and generates an executable file in the bin/Debug/net6.0 directory.
```bash
dotnet build
```

## Testing the Console App
To test the NQueensSolver Console App, follow these steps:

1. Navigate to the directory containing the C# Console App source code, and run the following command to run the tests:
```bash
cd RedDoor-Interview/NQueens.Test
```

2. run the following command to run the tests:
```bash
dotnet test
```

## More study:
> Does a 20x20 board run in acceptable time?

The 14 queens result `Number of solutions: 365596, runtime:00:00:20.9269937` tested on Intel I7-10750H 12 core CPU
For 20 queens on a 20x20 board creates such a huge tree. There's no any optimization capable of getting you an exact result in reasonable time for recently devices.

https://stackoverflow.com/questions/7131773/put-n-queens-can-it-possible-to-run-within-acceptable-time-with-n-20
