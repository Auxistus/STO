-- Set NOCHECK CONSTRAINT
ALTER TABLE [Catalog].[Component] DROP CONSTRAINT [FK_Component_ComponentType]
ALTER TABLE [Catalog].[Product_Component] DROP CONSTRAINT [FK_Product_Component_Component]
ALTER TABLE [Catalog].[Product_Component] DROP CONSTRAINT [FK_Product_Component_Product]


-- Catalog.ComponentType
INSERT INTO [Catalog].[ComponentType] ([Name], [IsVisible], [Created]) VALUES (N'řámeček', 1, '20161211 16:13:26.01')
INSERT INTO [Catalog].[ComponentType] ([Name], [IsVisible], [Created]) VALUES (N'kabinka', 1, '20161211 16:13:26.01')
INSERT INTO [Catalog].[ComponentType] ([Name], [IsVisible], [Created]) VALUES (N'obtisk', 1, '20161211 16:13:26.01')
INSERT INTO [Catalog].[ComponentType] ([Name], [IsVisible], [Created]) VALUES (N'resin', 1, '20161211 16:13:26.01')
INSERT INTO [Catalog].[ComponentType] ([Name], [IsVisible], [Created]) VALUES (N'plech', 1, '20161211 16:13:26.01')
INSERT INTO [Catalog].[ComponentType] ([Name], [IsVisible], [Created]) VALUES (N'dno krabice', 1, '20161211 16:13:26.01')
INSERT INTO [Catalog].[ComponentType] ([Name], [IsVisible], [Created]) VALUES (N'víko krabice', 1, '20161211 16:13:26.01')
INSERT INTO [Catalog].[ComponentType] ([Name], [IsVisible], [Created]) VALUES (N'návod', 1, '20161211 16:13:26.01')


-- Set CHECK CONSTRAINT
ALTER TABLE [Catalog].[Component] ADD CONSTRAINT [FK_Component_ComponentType] FOREIGN KEY ([ComponentTypeID]) REFERENCES [Catalog].[ComponentType] ([ID])
ALTER TABLE [Catalog].[Product_Component] ADD CONSTRAINT [FK_Product_Component_Component] FOREIGN KEY ([ComponentID]) REFERENCES [Catalog].[Component] ([ID])
ALTER TABLE [Catalog].[Product_Component] ADD CONSTRAINT [FK_Product_Component_Product] FOREIGN KEY ([ProductID]) REFERENCES [Catalog].[Product] ([ID])