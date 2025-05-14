CREATE TABLE WashingTypes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
	WashingTypeName NVARCHAR (30) NOT NULL,
	WashingTime INT NOT NULL,
	Description TEXT NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
)

INSERT INTO WashingTypes (WashingTypeName, WashingTime, Description, CreatedUserId, CreatedDate, LastUpdatedUserId, LastUpdatedDate, Status, IsDeleted)
VALUES 
	('Rinse', 38, 'A basic washing process to remove impurities and prepare the fabric for further treatments.' ,1, GETDATE(), 1, GETDATE(), 1, 0),
    ('Base', 35, 'An initial wash to clean and prepare the fabric before additional processes.' , 1, GETDATE(), 1, GETDATE(), 1, 0),
    ('Neutralization', 15, 'A process that balances the fabric’s pH level after chemical treatments.' , 1, GETDATE(), 1, GETDATE(), 1, 0),
	('Random', 50, 'Creates irregular fading and distressed effects on the fabric, giving it a unique look.', 1, GETDATE(), 1, GETDATE(), 1, 0),
	('Stone', 85, 'Uses pumice stones to achieve a rugged, aged look with enhanced softness.' ,1, GETDATE(), 1, GETDATE(), 1, 0),
	('Enzyme', 80, 'Uses enzymes to break down fibers, resulting in a softer feel and a natural worn effect.' , 1, GETDATE(), 1, GETDATE(), 1, 0),
	('Bleach', 70, 'Uses bleaching agents to lighten the fabric, creating a washed-out, faded appearance.' ,1, GETDATE(), 1, GETDATE(), 1, 0),
	('Ozone', 55, 'An eco-friendly process using ozone gas to bleach and lighten the fabric without excessive water usage.' ,1, GETDATE(), 1, GETDATE(), 1, 0),
	('Acid', 60, 'Produces a high-contrast marbled effect using chemical treatments.' ,1, GETDATE(), 1, GETDATE(), 1, 0),
	('Ice', 75, 'Creates a frosty, high-contrast look by using cold washing techniques.' ,1, GETDATE(), 1, GETDATE(), 1, 0),
	('E-flow', 25, 'A sustainable washing method that uses minimal water and chemicals for a refined finish.' ,1, GETDATE(), 1, GETDATE(), 1, 0),
	('Reactive', 90, 'Fixes colors into the fabric, ensuring long-lasting vibrancy and preventing fading.' ,1, GETDATE(), 1, GETDATE(), 1, 0),
	('Silicone', 50, 'Adds a silicone coating to the fabric, making it softer, smoother, and slightly glossy.' ,1, GETDATE(), 1, GETDATE(), 1, 0),
	('Softener', 20, 'Uses fabric softeners to enhance the fabric’s touch, giving it a plush and luxurious feel.' ,1, GETDATE(), 1, GETDATE(), 1, 0),
	('Resin ', 65, 'Adds a resin finish to make the fabric more structured and slightly stiff for a crisp look.' ,1, GETDATE(), 1, GETDATE(), 1, 0);



CREATE TABLE Fabrics (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FabricMaterials NVARCHAR(255) NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
);

ALTER TABLE Pants DROP CONSTRAINT FK_Pants_Fabrics;

INSERT INTO Fabrics (FabricMaterials, CreatedUserId, CreatedDate, LastUpdatedUserId, LastUpdatedDate, Status, IsDeleted)
VALUES
    ('%70 Cotton, %20 Polyester, %5 Spandex, %5 Nylon', 1, GETDATE(), 1, GETDATE(), 1, 0), --Cargo
    ('%60 Cotton, %30 Polyester, %10 Spandex', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Jogger
    ('%90 Cotton, %5 Polyester, %5 Spandex', 1, GETDATE(), 1, GETDATE(), 1, 0), --Corduroy
    ('%50 Cotton, %30 Polyester, %5 Spandex, %5 Linen, %10 Wool', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Pleated
    ('%75 Cotton, %15 Polyester, %5 Spandex, %5 Linen', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Capri
    ('%80 Cotton, %15 Polyester, %5 Spandex', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Bootcut
    ('%85 Cotton, %10 Polyester, %5 Spandex', 1, GETDATE(), 1, GETDATE(), 1, 0), -- High Rise
    ('%80 Cotton, %15 Polyester, %5 Spandex', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Khaki
    ('%50 Cotton, %35 Polyester, %10 Spandex, %5 Nylon', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Legging
    ('%40 Cotton, %20 Polyester, %5 Spandex, %35 Linen', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Linen
    ('%70 Cotton, %20 Polyester, %5 Spandex, %5 Viscose', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Lounge
    ('%80 Cotton, %15 Polyester, %5 Spandex', 1, GETDATE(), 1, GETDATE(), 1, 0),-- Cropped
    ('%40 Cotton, %30 Polyester, %5 Spandex %20 Linen, %5 Viscose', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Culotte
    ('%40 Cotton, %30 Polyester, %5 Spandex, %20 Linen, %5 Silk', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Palazzo
    ('%70 Cotton, %15 Polyester, %5 Spandex, %10 Linen', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Wide Leg
    ('%80 Cotton, %15 Polyester, %5 Spandex', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Bell Bottom
    ('%75 Cotton, %15 Polyester, %5 Spandex, %5 Linen', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Drawstring
    ('%80 Cotton, %15 Polyester, %5 Spandex', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Flared
    ('%20 Polyester, %5 Spandex, %75 Wool', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Wool
    ('%95 Cotton, %2 Polyester, %3 Spandex', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Jean
    ('%80 Cotton, %15 Polyester, %5 Spandex', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Chino
    ('%40 Cotton, %30 Polyester, %5 Spandex, %10 Linen, %15 Wool', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Dress
    ('%70 Cotton, %20 Polyester, %10 Spandex', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Sweatpant
    ('%60 Cotton, %20 Polyester, %5 Spandex, %15 Wool', 1, GETDATE(), 1, GETDATE(), 1, 0), -- Bermuda
    ('%90 Cotton, %5 Polyester, %5 Spandex', 1, GETDATE(), 1, GETDATE(), 1, 0); -- Overalls


CREATE TABLE Pants  (
    Id INT IDENTITY(1,1) PRIMARY KEY,
	FabricId INT NOT NULL,
	ModelName NVARCHAR(255) NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
	CONSTRAINT FK_Pants_Fabrics FOREIGN KEY (FabricId) REFERENCES Fabrics(Id)
);


INSERT INTO Pants (FabricId, ModelName, CreatedUserId, CreatedDate, LastUpdatedUserId, LastUpdatedDate, Status, IsDeleted)
VALUES
    (1, 'Relaxed Fit Cargo', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(1, 'Loose Fit Cargo', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(1, 'Tapered Fit Cargo', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(2, 'Tapered Fit Jogger', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(2, 'Slim Fit Jogger', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(2, 'Relaxed Fit Jogger', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(3, 'Slim Fit Corduroy', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(3, 'Straight Leg Corduroy', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(3, 'Wide Leg Corduroy', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(3, 'Bootcut Corduroy', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(4, 'Regular Fit Pleated', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(4, 'Regular Relaxed Fit Pleated', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(4, 'Regular Straight Leg Pleated', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(5, 'Slim Fit Capri', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(5, 'Straight Leg Capri', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(6, 'Fit Bootcut', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(7, 'Slim Fit High Rise', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(7, 'Straight LegHigh Rise', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(7, 'Wide Leg High Rise', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(8, 'Regular Fit Khaki', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(8, 'Slim Fit, Khaki', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(8, 'Straight Leg Khaki', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(9, 'Skinny Fit Legging', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(9, 'Bodycon Fit Legging', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(10, 'Relaxed Fit Linen', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(10, 'Wide Leg Linen', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(10, 'Straight Leg Linen', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(11, 'Loose Fit Lounge', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(11, 'Relaxed Fit Lounge', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(11, 'Tapered Fit Lounge', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(12, 'Slim Fit Cropped', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(12, 'Straight Leg Cropped', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(12, 'Wide Leg Cropped', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(13, 'Wide Leg Culotte', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(13, 'Loose Fit Culotte', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(14, 'Wide Leg Palazzo', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(14, 'Flared Fit Palazzo', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(15, 'Fit Wide Leg', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(15, 'Loose Fit Wide Leg', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(16, 'Flared Fit Bell Bottom', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(16, 'Bootcut Fit Bell Bottom', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(17, 'Relaxed Fit Drawstring', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(17, 'Loose Fit Drawstring', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(17, 'Tapered Fit Drawstring', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(18, 'Fit Flared', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(18, 'Bootcut Fit Flared', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(19, 'Regular Fit Wool', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(19, 'Slim Fit Wool', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(19, 'Straight Leg Wool', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(20, 'Skinny Fit Jean', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(20, 'Slim Fit Jean', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(20, 'Regular Fit Jean', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(20, 'Relaxed Fit Jean', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(20, 'Bootcut Jean', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(20, 'Flared Fit Jean', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(21, 'Slim Fit Chino', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(21, 'Regular Fit Chino', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(21, 'Tapered Fit Chino', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(22, 'Regular Fit Dress', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(22, 'Slim Fit Dress', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(22, 'Straight Leg Dress', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(23, 'Relaxed Fit Sweatpant', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(23, 'Loose Fit Sweatpant', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(23, 'Jogger Fit Sweatpant', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(24, 'Slim Fit Bermuda', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(24, 'Relaxed Fit Bermuda', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(24, 'Straight Fit Bermuda', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(25, 'Loose Fit Overalls', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(25, 'Relaxed Fit Overalls', 1, GETDATE(), 1, GETDATE(), 1, 0),
	(25, 'Straight Fit Overalls', 1, GETDATE(), 1, GETDATE(), 1, 0);


CREATE TABLE Machines (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    MachineName NVARCHAR(100) NOT NULL,
    MachineType NVARCHAR(20) NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
);

INSERT INTO Machines (MachineName, MachineType, CreatedUserId, CreatedDate, LastUpdatedUserId, LastUpdatedDate, Status, IsDeleted)
VALUES 
('A', 'Washing', 3, GETDATE(), 3, GETDATE(), 1, 0),
('B', 'Drying', 3, GETDATE(), 3, GETDATE(), 1, 0),
('C', 'Squeezing', 3, GETDATE(), 3, GETDATE(), 1, 0),
('D', 'Drying', 3, GETDATE(), 3, GETDATE(), 1, 0),
('E', 'Squeezing', 3, GETDATE(), 3, GETDATE(), 1, 0),
('F', 'Washing', 3, GETDATE(), 3, GETDATE(), 1, 0);




CREATE TABLE Employees (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(255) NOT NULL,
    Title NVARCHAR(100) NOT NULL,
    PhoneNumber NVARCHAR(20) NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
);


CREATE TABLE Orders (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    OrderNumber NVARCHAR(8) NOT NULL,
    PantId INT NOT NULL,
    PantQuantity INT NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
	CONSTRAINT UQ_Orders_OrderId UNIQUE (OrderNumber),
	CONSTRAINT FK_Orders_Pants FOREIGN KEY (PantId) REFERENCES Pants(Id),
);

ALTER TABLE Orders DROP CONSTRAINT FK_Orders_Pants;


CREATE TABLE Washes (
    Id INT IDENTITY(1,1) PRIMARY KEY,
	OrderId INT NOT NULL,
	WashingTypeId INT NOT NULL,
	MachineId INT NOT NULL,
    Shift NVARCHAR(20) NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
	CONSTRAINT FK_Washes_Orders FOREIGN KEY (OrderId) REFERENCES Orders(Id),
	CONSTRAINT FK_Washes_WashingTypes FOREIGN KEY (WashingTypeId) REFERENCES WashingTypes(Id),
	CONSTRAINT FK_Washes_Machines FOREIGN KEY (MachineId) REFERENCES Machines(Id),
);

INSERT INTO Washes (OrderId, WashingTypeId, MachineId, Shift, CreatedUserId, CreatedDate, LastUpdatedUserId, LastUpdatedDate, Status, IsDeleted)
VALUES 
(1, 2, 3, '1st shift', 3, GETDATE(), 3, GETDATE(), 1, 0),
(2, 1,2, '2nd shift', 4, GETDATE(), 4, GETDATE(), 1, 0),
(1, 5,2, '1st shift', 2, GETDATE(), 2, GETDATE(), 1, 0),
(2, 6,4, '3rd shift', 1, GETDATE(), 1, GETDATE(), 0, 0),
(2, 10,5, '3rd shift', 5, GETDATE(), 5, GETDATE(), 1, 1),
(4, 1,6, '1st shift', 3, GETDATE(), 3, GETDATE(), 1, 0),
(4, 2,4, '2nd shift', 4, GETDATE(), 4, GETDATE(), 1, 0),
(4, 6,3, '1st shift', 2, GETDATE(), 2, GETDATE(), 1, 0),
(4, 4,2, '3rd shift', 1, GETDATE(), 1, GETDATE(), 0, 0),
(4, 12,5, '3rd shift', 5, GETDATE(), 5, GETDATE(), 1, 1);



CREATE TABLE DefectCategories (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(20) NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
);

INSERT INTO DefectCategories (CategoryName, CreatedUserId, CreatedDate, LastUpdatedUserId, LastUpdatedDate, Status, IsDeleted)
VALUES 
('Critical', 3, GETDATE(), 3, GETDATE(), 1, 0),
('Major', 3, GETDATE(), 3, GETDATE(), 1, 0),
('Minor', 3, GETDATE(), 3, GETDATE(), 1, 0),
('Positive', 3, GETDATE(), 3, GETDATE(), 1, 0);


CREATE TABLE Defects (
    Id INT IDENTITY(1,1) PRIMARY KEY,
	DefectCategoryId INT NOT NULL,
    DefectName NVARCHAR(50) NOT NULL,
	Description NVARCHAR(255) NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
	CONSTRAINT FK_Defects_DefectCategories FOREIGN KEY (DefectCategoryId) REFERENCES DefectCategories(Id),
);

INSERT INTO Defects (DefectCategoryId, DefectName, Description, CreatedUserId, CreatedDate, LastUpdatedUserId, LastUpdatedDate, Status, IsDeleted)
VALUES 
(1,'Chemical Mark','Irregular mark due to chemical exposure or residue', 3, GETDATE(), 3, GETDATE(), 1, 0),
(1,'Hole or Tear','Any visible hole or tearing in the fabric', 3, GETDATE(), 3, GETDATE(), 1, 0),
(1,'Sharp Metal Part','Exposed or sharp edge on metal parts', 3, GETDATE(), 3, GETDATE(), 1, 0),
(1,'Broken Zipper','Zipper not functioning or missing', 3, GETDATE(), 3, GETDATE(), 1, 0),
(1,'Rusty Accessory','Visible rust on rivets or metal parts', 3, GETDATE(), 3, GETDATE(), 1, 0),
(2,'Shade Variation','Color inconsistency across different fabric areas', 3, GETDATE(), 3, GETDATE(), 1, 0),
(2,'Oil or Dirt Stain','Visible oil, dirt, or greasy spots on the fabric', 3, GETDATE(), 3, GETDATE(), 1, 0),
(2,'Fabric Thinning','Excessively thin or worn-out areas', 3, GETDATE(), 3, GETDATE(), 1, 0),
(2,'Broken Stitch','Stitch line interrupted or open', 3, GETDATE(), 3, GETDATE(), 1, 0),
(2,'Missing Button','Button is not attached or missing', 3, GETDATE(), 3, GETDATE(), 1, 0),
(2,'Musty or Chemical Odor','Unpleasant or chemical smell on garment', 3, GETDATE(), 3, GETDATE(), 1, 0),
(2,'Irregular Wash Effect','Uneven or patchy wash effect on the fabric', 3, GETDATE(), 3, GETDATE(), 1, 0),
(2,'Twisted Leg','Pants leg twists when laid flat', 3, GETDATE(), 3, GETDATE(), 1, 0),
(2,'Missing Rivet','Decorative or structural rivet is absent', 3, GETDATE(), 3, GETDATE(), 1, 0),
(3,'Excessively Stiff Fabric','Fabric is too stiff or hard after wash', 3, GETDATE(), 3, GETDATE(), 1, 0),
(3,'Misplaced Label','Label sewn incorrectly or in wrong position', 3, GETDATE(), 3, GETDATE(), 1, 0),
(3,'Yarn Snag or Pull','Pulled thread or snag on fabric surface', 3, GETDATE(), 3, GETDATE(), 1, 0),
(3,'Wrong Size','Measured size does not match label or size chart', 3, GETDATE(), 3, GETDATE(), 1, 0),
(3,'Loose Thread','Hanging or extra thread at seams, or greasy spots on the fabric.', 3, GETDATE(), 3, GETDATE(), 1, 0),
(3,'Unreadable Label','Printed info on the label is faded or unclear', 3, GETDATE(), 3, GETDATE(), 1, 0),
(4, 'Approved for Sale', 'The product meets all quality standards and is suitable for sale without any remarks.', 3, GETDATE(), 3, GETDATE(), 1, 0),
(4, 'Acceptable Minor Flaw', 'Contains a very minor imperfection that does not affect the products function or appearance.', 3, GETDATE(), 3, GETDATE(), 1, 0),
(4, 'Passed Visual Inspection', 'No visible defects found during inspection. Product is ready for packaging and sale.', 3, GETDATE(), 3, GETDATE(), 1, 0),
(4, 'First Quality', 'Top-grade product with no defects. Meets all visual, dimensional, and functional criteria.', 3, GETDATE(), 3, GETDATE(), 1, 0);




CREATE TABLE OrderDefects (
    Id INT IDENTITY(1,1) PRIMARY KEY,
	OrderId INT NOT NULL,
    DefectId INT NOT NULL,
    RowNumber INT NOT NULL,
	Decision NVARCHAR(20) NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
	CONSTRAINT FK_OrderDefects_Orders FOREIGN KEY (OrderId) REFERENCES Orders(Id),
	CONSTRAINT FK_OrderDefects_Defects FOREIGN KEY (DefectId) REFERENCES Defects(Id)
);



INSERT INTO OrderDefects (OrderId, DefectId, RowNumber, Decision, CreatedUserId, CreatedDate, LastUpdatedUserId, LastUpdatedDate, Status, IsDeleted)
VALUES 
(1, 1, 1, 'Accept', 1, GETDATE(), 1, GETDATE(), 1, 0),
(2, 2, 2, 'Reject', 1, GETDATE(), 1, GETDATE(), 1, 0),
(3, 3, 3, 'Accept', 1, GETDATE(), 1, GETDATE(), 1, 0),
(4, 4, 4, 'Reject', 1, GETDATE(), 1, GETDATE(), 1, 0),
(5, 5, 5, 'Accept', 1, GETDATE(), 1, GETDATE(), 1, 0),
(6, 6, 6, 'Reject', 1, GETDATE(), 1, GETDATE(), 1, 0),
(1, 7, 7, 'Accept', 1, GETDATE(), 1, GETDATE(), 1, 0),
(2, 8, 8, 'Reject', 1, GETDATE(), 1, GETDATE(), 1, 0),
(3, 9, 9, 'Accept', 1, GETDATE(), 1, GETDATE(), 1, 0),
(4, 10, 10, 'Reject', 1, GETDATE(), 1, GETDATE(), 1, 0),
(5, 11, 11, 'Accept', 1, GETDATE(), 1, GETDATE(), 1, 0),
(6, 12, 12, 'Reject', 1, GETDATE(), 1, GETDATE(), 1, 0),
(1, 13, 13, 'Accept', 1, GETDATE(), 1, GETDATE(), 1, 0),
(2, 14, 14, 'Reject', 1, GETDATE(), 1, GETDATE(), 1, 0),
(3, 15, 15, 'Accept', 1, GETDATE(), 1, GETDATE(), 1, 0),
(4, 16, 16, 'Reject', 1, GETDATE(), 1, GETDATE(), 1, 0),
(5, 17, 17, 'Accept', 1, GETDATE(), 1, GETDATE(), 1, 0),
(6, 18, 18, 'Reject', 1, GETDATE(), 1, GETDATE(), 1, 0),
(1, 19, 19, 'Accept', 1, GETDATE(), 1, GETDATE(), 1, 0),
(2, 20, 20, 'Reject', 1, GETDATE(), 1, GETDATE(), 1, 0);



CREATE TABLE QualityControls (
    Id INT IDENTITY(1,1) PRIMARY KEY,
	OrderId INT NOT NULL,
	Result NVARCHAR(20) NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
	CONSTRAINT FK_QualityControls_Orders FOREIGN KEY (OrderId) REFERENCES Orders(Id),
);



CREATE TABLE Language (
    Id INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL,
    Code NVARCHAR(10) NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
);

INSERT INTO Language (Name, Code, CreatedUserId, CreatedDate, LastUpdatedUserId, LastUpdatedDate, Status, IsDeleted) VALUES ('English', 'en' , 1, GETDATE(), 1, GETDATE(), 1, 0);
INSERT INTO Language (Name, Code, CreatedUserId, CreatedDate, LastUpdatedUserId, LastUpdatedDate, Status, IsDeleted) VALUES ('Türkçe', 'tr' , 1, GETDATE(), 1, GETDATE(), 1, 0);


CREATE TABLE Translate (
    Id INT IDENTITY(1,1) PRIMARY KEY,
	LangId INT NOT NULL,
    Code NVARCHAR(100) NOT NULL,
    Value NVARCHAR(MAX) NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
	CONSTRAINT FK_Translate_Language FOREIGN KEY (LangId) REFERENCES Language(Id)
);


INSERT INTO Translate (LangId,Code, Value, CreatedUserId, CreatedDate, LastUpdatedUserId, LastUpdatedDate, Status, IsDeleted) 
VALUES 
(1,'PASSWORD', 'Password' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'PASSWORD', 'Şifre' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'SIGN_IN', 'Sign in' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'SIGN_IN', 'Giriş yap' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'SING_UP', 'Sing up' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'SING_UP', 'Kayıt ol' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'FIRST_NAME', 'First Name' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'FIRST_NAME', 'Ad' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'LAST_NAME', 'Last Name' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'LAST_NAME', 'Soyad' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'PHONE_NUMBER', 'Phone Number' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'PHONE_NUMBER', 'Telefon Numarası' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'GENDER', 'Gender' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'GENDER', 'Cinsiyet' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'MALE', 'Male' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'MALE', 'Erkek' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'FEMALE', 'Female' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'FEMALE', 'Kadın' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'OTHER', 'Other' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'OTHER', 'Diğer' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'CLEAR_SELECTION', 'Clear Selection' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'CLEAR_SELECTION', 'Seçimi Temizle' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'LOGIN', 'Login' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'LOGIN', 'Giriş' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'QUALITY_CONTROL', 'Quality Control' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'QUALITY_CONTROL', 'Kalite Kontrol' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'WASHING', 'Washing' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'WASHING', 'Yıkama' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'ORDER', 'Order' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'ORDER', 'Sipariş' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'MACHINE', 'Machine' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'MACHINE', 'Makine' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'DEFECT', 'Defect' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'DEFECT', 'Kusur' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'SIGN_OUT', 'Sign out' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'SIGN_OUT', 'Çıkış yap' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'ORDER_NUMBER', 'Order Number' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'ORDER_NUMBER', 'Sipariş Numarası' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'QUANTITY', 'Quantity' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'QUANTITY', 'Miktar' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'CREATED_DATE', 'Created Date' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'CREATED_DATE', 'Oluşturma Tarihi' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'NO_ORDER_DATA', 'No order data found' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'NO_ORDER_DATA', 'Sipariş verisi bulunamadı' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'TOTAL', 'Total' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'TOTAL', 'Toplam' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'ACCEPT', 'Accept' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'ACCEPT', 'Kabul' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'REJECT', 'Reject' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'REJECT', 'Red' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'NOT_DECIDED', 'Not Decided' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'NOT_DECIDED', 'Karar Verilmedi' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'SHIP', 'Ship' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'SHIP', 'Kargo' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'REPAIR', 'Repair' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'REPAIR', 'Tamir' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'NOT_ACCEPTED', 'Not Accepted' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'NOT_ACCEPTED', 'Kabul Edilmedi' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'ROW', 'Row' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'ROW', 'Sıra' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'LAST_UPDATED_DATE', 'Last Updated Date' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'LAST_UPDATED_DATE', 'Son Güncelleme Tarihi' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'NO_DECISION_DATA', 'No decision data found' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'NO_DECISION_DATA', 'Karar verisi bulunamadı' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'START_QUALITY_CONTROL', 'Start Quality Control' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'START_QUALITY_CONTROL', 'Kalite Kontrolü Başlat' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'ARE_YOU_SURE_DECISION', 'Are you sure the final decision ?' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'ARE_YOU_SURE_DECISION', 'Son kararınızdan emin misiniz ?' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'YES', 'Yes' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'YES', 'Evet' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'NO', 'No' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'NO', 'Hayır' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'QUALITY_CONTROL_COMPLETED', 'Quality control completed, Go back and make your final decision' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'QUALITY_CONTROL_COMPLETED', 'Kalite kontrolü tamamlandı, geri dönün ve son kararınızı verin' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'SAVE_DECISION', 'Save Decision' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'SAVE_DECISION', 'Kararı Kaydet' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'WASH', 'Wash' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'WASH', 'Yıka' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'WASHING_TYPES_INFO', 'Washing Types Info' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'WASHING_TYPES_INFO', 'Yıkama Türleri Bilgisi' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'MIN', 'min' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'MIN', 'dakika' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'NO_WASH_DATA', 'No wash data found' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'NO_WASH_DATA', 'Yıkama verisi bulunamadı' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'START_NEW_WASH', 'Start New Wash' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'START_NEW_WASH', 'Yeni Yıkamayı Başlat' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'COMPLETED', 'Completed' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'COMPLETED', 'Tamamlandı' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'IN_PROGRESS', 'In Progress' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'IN_PROGRESS', 'Devam etmekte' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'SELECT_WASHING_OPTIONS', 'Select washing options' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'SELECT_WASHING_OPTIONS', 'Yıkama seçeneklerini seçin' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'1ST_SHIFT', '1st shift' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'1ST_SHIFT', '1. vardiya' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'2ND_SHIFT', '2nd shift' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'2ND_SHIFT', '2. vardiya' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'START', 'Start' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'START', 'Başlat' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'PANT_MODEL', 'Pant Model' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'PANT_MODEL', 'Pantolon Modeli' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'PANT_QUANTITY', 'Pant Quantity' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'PANT_QUANTITY', 'Pantolon Miktarı' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'CREATE_ORDER', 'Create Order' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'CREATE_ORDER', 'Sipariş Oluştur' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'MACHINE_NAME', 'Machine Name' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'MACHINE_NAME', 'Makine Adı' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'DRYING', 'Drying' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'DRYING', 'Kurutma' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'SQUEEZING', 'Squeezing' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'SQUEEZING', 'Sıkma' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'ADD_MACHINE', 'Add Machine' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'ADD_MACHINE', 'Makineyi Ekle' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'RESULT', 'Result' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'RESULT', 'Sonuç' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'DECISION', 'Decision' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'DECISION', 'Karar' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(1,'ARE_YOU_SURE_ACCEPT_PANT', 'Are you sure you want to accept this pant ?' , 1, GETDATE(), 1, GETDATE(), 1, 0),
(2,'ARE_YOU_SURE_ACCEPT_PANT', 'Bu pantolonu kabul etmek istediğinizden emin misiniz?' , 1, GETDATE(), 1, GETDATE(), 1, 0);



CREATE TABLE Users (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    PhoneNumber NVARCHAR(20) NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Gender CHAR(50) NULL,
    PasswordHash VARBINARY(512) NOT NULL,
    PasswordSalt VARBINARY(512) NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
);

CREATE TABLE OperationClaims (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(250) NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
);

CREATE TABLE UserOperationClaims (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UserId INT NOT NULL,
	OperationClaimId INT NOT NULL,
    CreatedUserId INT NOT NULL,
    CreatedDate DATETIME NOT NULL,
    LastUpdatedUserId INT NOT NULL,
    LastUpdatedDate DATETIME NOT NULL,
    Status BIT NOT NULL,
    IsDeleted BIT NOT NULL,
	CONSTRAINT FK_UserOperationClaims_Users FOREIGN KEY (UserId) REFERENCES Users(Id),
	CONSTRAINT FK_UserOperationClaims_OperationClaims FOREIGN KEY (OperationClaimId) REFERENCES OperationClaims(Id)
);
