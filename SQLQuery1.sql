CREATE PROC ViewAllVehicles
AS
BEGIN
SELECT v.VehicleId,v.VehicleName,v.VehicleCode,v.LaunchDate,v.IsAvailable,v.ImagePath,v.EngineType,
(SELECT SUM(Price) FROM ModelWithPrice WHERE VehicleId =v.VehicleId) AS TotalModelWithPrice,
c.CategoryId,v.ImagePath
FROM Vehicle v JOIN Category c
ON v.CategoryId = c.CategoryId
END