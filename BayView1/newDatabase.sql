--
-- File generated with SQLiteStudio v3.2.1 on Thu Jan 17 10:19:29 2019
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: BookingOrders
CREATE TABLE BookingOrders (OrderNo INTEGER PRIMARY KEY AUTOINCREMENT, BookingNo INTEGER REFERENCES Bookings (BookingNo), StaffNo INTEGER REFERENCES Staff (StaffNo), RoomNo INTEGER REFERENCES Rooms (RoomNo), "Person(s)Quantity" INTEGER, OrderDate DATETIME, totalPaid CURRENCY);

-- Table: Bookings
CREATE TABLE Bookings (BookingNo INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, DateDue DATE, DateOut DATE, CustomerNo INTEGER NOT NULL REFERENCES Customers (CustomerNo), StaffNo INTEGER NOT NULL REFERENCES Staff (StaffNo), RoomNo INTEGER NOT NULL REFERENCES Rooms (RoomNo), Duration INTEGER, TotalPayment CURRENCY);
INSERT INTO Bookings (BookingNo, DateDue, DateOut, CustomerNo, StaffNo, RoomNo, Duration, TotalPayment) VALUES (1, 2019, 2019, 1, 1, 1, NULL, NULL);
INSERT INTO Bookings (BookingNo, DateDue, DateOut, CustomerNo, StaffNo, RoomNo, Duration, TotalPayment) VALUES (2, 2019, 2019, 2, 2, 2, NULL, NULL);
INSERT INTO Bookings (BookingNo, DateDue, DateOut, CustomerNo, StaffNo, RoomNo, Duration, TotalPayment) VALUES (3, '', '', 5, 4, 7, 2, 150);
INSERT INTO Bookings (BookingNo, DateDue, DateOut, CustomerNo, StaffNo, RoomNo, Duration, TotalPayment) VALUES (4, 2081, 2019, 5, 4, 7, 2, 150);
INSERT INTO Bookings (BookingNo, DateDue, DateOut, CustomerNo, StaffNo, RoomNo, Duration, TotalPayment) VALUES (5, '2019-20-19', '2019-20-12', 4, 4, 6, 1, 75);

-- Table: Customers
CREATE TABLE Customers (CustomerNo INTEGER PRIMARY KEY AUTOINCREMENT, Title VARCHAR (6) NOT NULL, FirstName VARCHAR (50) NOT NULL, LastName VARCHAR (50) NOT NULL, Email VARCHAR (100) NOT NULL, PhoneNo VARCHAR (11) NOT NULL, PostCode VARCHAR (8) NOT NULL);
INSERT INTO Customers (CustomerNo, Title, FirstName, LastName, Email, PhoneNo, PostCode) VALUES (1, 'MR!!!', 'Chang', 'Xu', 'ChangTheMan@gmail.com', '01443 873852', 'CF37 4JA');
INSERT INTO Customers (CustomerNo, Title, FirstName, LastName, Email, PhoneNo, PostCode) VALUES (2, 'Master', 'Mark', 'Baber', 'markbaber@gmail.com', '07907778520', 'CF37 4JA');
INSERT INTO Customers (CustomerNo, Title, FirstName, LastName, Email, PhoneNo, PostCode) VALUES (3, 'Ms', 'Deva', 'Disanayake', 'Deva@gmail.com', '07908528520', 'CF37 8LQ');
INSERT INTO Customers (CustomerNo, Title, FirstName, LastName, Email, PhoneNo, PostCode) VALUES (4, 'Master', 'Dez', 'Ray', 'DezRay@msn.com', '07908524560', 'CF37 3PA');
INSERT INTO Customers (CustomerNo, Title, FirstName, LastName, Email, PhoneNo, PostCode) VALUES (5, 'Ms', 'Deva', 'Disanayake', 'Deva@gmail.com', '07908528520', 'CF37 8LQ');
INSERT INTO Customers (CustomerNo, Title, FirstName, LastName, Email, PhoneNo, PostCode) VALUES (6, 'Miss', 'Annie', 'Clark', 'StVincent@gmail.co.uk', '01443 873654', 'CF37 8LA');
INSERT INTO Customers (CustomerNo, Title, FirstName, LastName, Email, PhoneNo, PostCode) VALUES (7, 'Mrs', 'Elizabeth', 'Margret', 'ElizabethM@gmail.com', '07984 045632', 'NP44 7IT');

-- Table: Rooms
CREATE TABLE Rooms (RoomNo INTEGER PRIMARY KEY AUTOINCREMENT, RoomNumber VARCHAR (255), RoomType VARCHAR (255), Disability INTEGER, Room_Availability TEXT, Display TEXT, Expected_Availability INTEGER, WithBreakfast TEXT, Room_Price CURRENCY, WithBreakfast_Price CURRENCY, Total_Price CURRENCY);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (1, 'SR1', 'SingleRoom', 1, 'YES', 'singleroom.jpg', NULL, 'YES', 70, 75, 75);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (2, 'SR2', 'SingleRoom', 0, 'YES', 'singleroom1.jpg', NULL, 'YES', 70, 75, 75);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (3, 'SR3', 'SingleRoom', 1, 'YES', 'singleroom2.jpg', NULL, 'NO', 70, 75, 70);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (4, 'SR4', 'SingleRoom', 0, 'NO', 'singleroom3.jpg', '2019/01/03', 'NO', 70, 75, 70);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (5, 'SR5', 'SingleRoom', 0, 'NO', 'singleroom4.jpg', '2019/01/08', 'YES', 70, 75, 75);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (6, 'SR6', 'SingleRoom', 0, 'YES', 'singleroom5.jpg', NULL, 'YES', 70, 75, 75);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (7, 'SR7', 'SingleRoom', 0, 'YES', 'room3.jpg', NULL, 'YES', 70, 75, 75);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (8, 'SR8', 'SingleRoom', 0, 'YES', 'singleroom7.jpg', NULL, 'NO', 70, 75, 70);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (9, 'SR9', 'SingleRoom', 0, 'NO', 'singleroom8.jpg', '2019/01/05', 'YES', 70, 75, 75);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (10, 'SR10', 'SingleRoom', 0, 'YES', 'singleroom9.jpg', NULL, 'NO', 70, 75, 70);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (11, 'SR11', 'SingleRoom', 0, 'YES', 'singleroom10.jpg', NULL, 'NO', 70, 75, 70);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (12, 'SR12', 'SingleRoom', 0, 'NO', 'singleroom11.jpg', NULL, 'NO', 70, 75, 70);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (13, 'SR13', 'SingleRoom', 0, 'NO', 'singleroom12.jpg', NULL, 'YES', 70, 75, 75);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (14, 'SR14', 'SingleRoom', 0, 'YES', 'singleroom13.jpg', NULL, 'YES', 70, 75, 75);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (15, 'SR15', 'SingleRoom', 0, 'YES', 'singleroom14.jpg', NULL, 'YES', 70, 75, 75);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (16, 'SR16', 'SingleRoom', 0, 'NO', 'singleroom15.jpg', NULL, 'YES', 70, 75, 75);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (17, 'SR17', 'SingleRoom', 0, 'NO', 'singleroom16.jpg', NULL, 'NO', 70, 75, 70);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (18, 'SR18', 'SingleRoom', 0, 'YES', 'singleroom17.jpg', NULL, 'NO', 70, 75, 70);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (19, 'DR1', 'DoubleRoom', 1, 'YES', 'doubleroom.jpg', NULL, 'YES', 110, 120, 120);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (20, 'DR2', 'DoubleRoom', 0, 'YES', 'doubleroom1.jpg', NULL, 'YES', 110, 120, 120);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (21, 'DR3', 'DoubleRoom', 0, 'YES', 'doubleroom2.jpg', NULL, 'YES', 90, 95, 95);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (22, 'DR4', 'DoubleRoom', 0, 'NO', 'doubleroom3.jpg', NULL, 'NO', 90, 95, 90);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (23, 'DR5', 'DoubleRoom', 0, 'NO', 'doubleroom4.jpg', NULL, 'NO', 110, 120, 110);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (24, 'DR6', 'DoubleRoom', 0, 'NO', 'doubleroom5.jpg', NULL, 'YES', 90, 95, 120);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (25, 'DR7', 'DoubleRoom', 0, 'YES', 'doubleroom6.jpg', NULL, 'YES', 110, 120, 120);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (26, 'DR8', 'DoubleRoom', 0, 'YES', 'doubleroom7.jpg', NULL, 'YES', 110, 120, 120);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (27, 'FR1', 'FamilyRoom', 1, 'YES', 'familyroom.jpg', NULL, 'YES', 160, 175, 175);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (28, 'FR2', 'FamilyRoom', 0, 'YES', 'familyroom1.jpg', NULL, 'YES', 160, 175, 175);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (29, 'FR3', 'FamilyRoom', 0, 'NO', 'familyroom2.jpg', NULL, 'NO', 160, 175, 160);
INSERT INTO Rooms (RoomNo, RoomNumber, RoomType, Disability, Room_Availability, Display, Expected_Availability, WithBreakfast, Room_Price, WithBreakfast_Price, Total_Price) VALUES (30, 'FR4', 'FamilyRoom', 0, 'YES', 'familyroom3.jpg', NULL, 'NO', 160, 175, 160);

-- Table: Staff
CREATE TABLE Staff (StaffNo INTEGER PRIMARY KEY AUTOINCREMENT, Title VARCHAR (6) NOT NULL, FirstName VARCHAR (50) NOT NULL, LastName VARCHAR (50) NOT NULL, Password VARCHAR (10) NOT NULL, Email VARCHAR (100) NOT NULL, PhoneNo VARCHAR (11) NOT NULL, Manager BOOLEAN NOT NULL, Username VARCHAR (50) NOT NULL UNIQUE);
INSERT INTO Staff (StaffNo, Title, FirstName, LastName, Password, Email, PhoneNo, Manager, Username) VALUES (1, 'Mr', 'Mark', 'Baber', 'Baber', 'MB@gmail.com', '07907770742', 0, 'Mark Baber');
INSERT INTO Staff (StaffNo, Title, FirstName, LastName, Password, Email, PhoneNo, Manager, Username) VALUES (2, 'Mrs', 'Deva', 'Dissanayake', 'Deva', 'DD@gmail.com', '07945613284', 0, 'Deva');
INSERT INTO Staff (StaffNo, Title, FirstName, LastName, Password, Email, PhoneNo, Manager, Username) VALUES (3, 'Mr', 'Dez', 'Ray', 'Dez', 'dez@gmail.com', '07907770384', 0, 'Dez');
INSERT INTO Staff (StaffNo, Title, FirstName, LastName, Password, Email, PhoneNo, Manager, Username) VALUES (4, 'Master', 'Chang', 'Xu', 'Chang', 'chang@email.com', '07854123654', 0, 'Chang');
INSERT INTO Staff (StaffNo, Title, FirstName, LastName, Password, Email, PhoneNo, Manager, Username) VALUES (5, 'Mr', 'Kallam', 'Rossaye', 'Kallam', 'kallamboi@gmail.com', '07943546987', 0, 'Kallam');
INSERT INTO Staff (StaffNo, Title, FirstName, LastName, Password, Email, PhoneNo, Manager, Username) VALUES (6, 'X', 'Manager', 'Bossman', 'Password', 'contact@bayview.co.uk', '01443 873456', 1, 'Manager');

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
