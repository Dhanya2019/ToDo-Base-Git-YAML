﻿CREATE TABLE [dbo].[TodoItems] (
    [Id]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (MAX) NULL,
    [IsComplete] BIT            NOT NULL,
    CONSTRAINT [PK_TodoItems] PRIMARY KEY CLUSTERED ([Id] ASC)
);

