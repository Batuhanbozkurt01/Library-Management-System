CREATE TABLE [dbo].[Users] (
    [UserID]   INT IDENTITY(1,1) NOT NULL,
    [Username] NVARCHAR(50) NOT NULL,
    [Password] NVARCHAR(50) NOT NULL,
    [Email]    NVARCHAR(100) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);

CREATE TABLE [dbo].[Books] (
    [BookID] INT IDENTITY(1,1) NOT NULL,
    [Title] NVARCHAR(100) NOT NULL,
    [Author] NVARCHAR(50) NOT NULL,
    [PublicationYear] INT NULL,
    [Genre] NVARCHAR(50) NULL,
    PRIMARY KEY CLUSTERED ([BookID] ASC)
);

CREATE TABLE [dbo].[Reviews] (
    [ReviewID] INT IDENTITY(1,1) NOT NULL,
    [UserID] INT NOT NULL,
    [BookID] INT NOT NULL,
    [Rating] FLOAT NOT NULL,
    [Comment] NVARCHAR(500) NULL,
    PRIMARY KEY CLUSTERED ([ReviewID] ASC),
    CONSTRAINT FK_Reviews_Users FOREIGN KEY (UserID)
        REFERENCES Users(UserID),
    CONSTRAINT FK_Reviews_Books FOREIGN KEY (BookID)
        REFERENCES Books(BookID)
);
