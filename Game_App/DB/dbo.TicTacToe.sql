CREATE TABLE [dbo].[TicTacToe] (
    [TicTacToeId] INT IDENTITY (1, 1) NOT NULL,
    [Wins]        INT NOT NULL,
    [Loses]       INT NOT NULL,
    PRIMARY KEY CLUSTERED ([TicTacToeId] ASC)
);

