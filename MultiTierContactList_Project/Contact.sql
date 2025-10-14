CREATE TABLE [dbo].[Contact] (
    [Id]        INT           NOT NULL,
    [FirstName] VARCHAR (50)  NOT NULL,
    [LastName]  VARCHAR (50)  NOT NULL,
    [Email]     VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Email] ASC)
);