

/****** Object:  View [SalesLT].[vGetAllCategories]    Script Date: 6/26/2015 8:11:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER VIEW [SalesLT].[vProductListing]
AS 

SELECT 
P.[ProductID]
      ,P.[Name]
      ,P.[ProductNumber]
      ,P.[Color]
      ,P.[StandardCost]
      ,P.[ListPrice]
      ,P.[Size]
      ,P.[Weight]
      ,P.[ProductCategoryID]
      ,P.[ProductModelID]
      ,P.[SellStartDate]
      ,P.[SellEndDate]
      ,P.[DiscontinuedDate]
      ,P.[ThumbnailPhotoFileName]
	  ,PM.Name AS ModelName
	  ,PC.Name AS CategoryName
	  ,PC.ParentProductCategoryID
	  ,PAD.Description

FROM SalesLT.Product P
Left JOIN SalesLT.ProductCategory PC ON P.ProductCategoryID = PC.ProductCategoryID
Left JOIN SalesLT.ProductModel PM ON P.ProductModelID = PM.ProductModelID
LEft JOIN [SalesLT].[vProductAndDescription] PAD ON PAD.ProductID = P.ProductID
WHERE PAD.Culture = 'en'
GO


