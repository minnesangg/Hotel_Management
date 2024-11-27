USE HotelManagment;
GO

-- ��������� ������� ��� ������
CREATE TABLE Guests (
    GuestID INT PRIMARY KEY,
    Name VARCHAR(40),
    Date DATETIME,
    Address VARCHAR(60),
    Town VARCHAR(20),
    Aim VARCHAR(30),
    Passport VARCHAR(20),
    PassportDate DATETIME,
    Region VARCHAR(40),
    Work VARCHAR(20),
    Year INT,
    Money DECIMAL(10, 2),
    Cash BIT,
    Receipt INT,
    DepartureDate DATETIME, -- ������� "End" �� "DepartureDate"
    Comment TEXT,
    Registrar VARCHAR(15),
    Picture VARBINARY(MAX)
);

-- ��������� ������� ��� ������
CREATE TABLE Rooms (
    Number INT PRIMARY KEY,
    Rooms INT,
    Storey INT,
    TV BIT,
    Fridge BIT,
    Bed INT,
    Type INT,
    Balcony BIT,
    Reservation INT, -- ����'���� �� ReservationID
    FOREIGN KEY (Reservation) REFERENCES Reservations(ReservationID)
);
CREATE TABLE RoomTypes (
    Type INT PRIMARY KEY,
    TypeName VARCHAR(50)
);


-- ��������� ������� ��� ���������
CREATE TABLE Reservations (
    ReservationID INT PRIMARY KEY,
    GuestID INT, -- ������������� �����, �� ������ �����
    ReservName VARCHAR(40),
    Come DATETIME,
    Leave DATETIME,
    FOREIGN KEY (GuestID) REFERENCES Guests(GuestID) -- ��'���� � �������� Guests
);

CREATE TABLE Guests_Archive (
    GuestID INT PRIMARY KEY,
    Name VARCHAR(40),
    Money DECIMAL(10, 2),
    StayEnded DATETIME
);

-- ������� �������� ����� � ������� Guests
INSERT INTO Guests (GuestID, Name, Date, Address, Town, Aim, Passport, PassportDate, Region, Work, Year, Money, Cash, Receipt, DepartureDate, Comment, Registrar, Picture)
VALUES 
(1, '���� ������', '2024-11-01', '���. ��������, 1', '���', '������', 'AB123456', '2020-05-01', '���', '��� "�������"', 1990, 2000.00, 1, 1001, '2024-11-05', '����', '��������', NULL);


INSERT INTO Guests (GuestID, Name, Money, Date)
VALUES (10, '����� ������', 1000, '2024-11-01');

-- ������� �������� ����� � ������� Rooms
INSERT INTO Rooms (Number, Rooms, Storey, TV, Fridge, Bed, Type, Balcony, Reservation)
VALUES 
(101, 2, 1, 1, 1, 2, 1, 1, 1), -- ����'����� �� ReservationID = 1
(102, 1, 2, 0, 1, 1, 2, 0, NULL); -- �� ����'����� �� ����������� ����������

-- �������� ����� � ��������
SELECT * FROM Guests;
SELECT * FROM Rooms;
SELECT * FROM Reservations;
SELECT * FROM Guests_Archive;
GO




