﻿CREATE TABLE [dbo].[Countries] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (256) NOT NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED ([Id] ASC)
);

