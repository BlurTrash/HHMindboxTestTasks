USE HHTask2MindboxDB
go

SElECT P.Name As ProductName, C.Name As CategoryName
From Products As P
LEFT JOIN ProductsCategories As PC 
ON P.Id = PC.ProductId
LEFT JOIN Categories AS C
ON PC.CategoryId = C.Id
ORDER BY P.Name