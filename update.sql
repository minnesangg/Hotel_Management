USE HotelManagment;
GO

BEGIN TRANSACTION;

-- 1. ��������� ������ ����� � GuestID = 1
UPDATE Guests
SET Money = Money + 100
WHERE GuestID = 1;

-- 2. ��������� ������ �����
INSERT INTO Guests (GuestID, Name, Money, Date)
VALUES (4, 'John Doe', 0, '2024-11-10');

-- 3. ��������� �����, ���� �����
DELETE FROM Guests
WHERE GuestID = 4;

-- 4. ������� ����� � ������� �������
INSERT INTO Guests (GuestID, Name, Money, Date)
SELECT GuestID, Name, Money, '2024-11-10'
FROM Guests_Archive
WHERE StayEnded = 1;

-- 5. ��������� ������ ��� ������ � ����������� �����������
UPDATE Guests
SET Money = Money + 50
FROM Guests
JOIN Reservations ON Guests.GuestID = Reservations.GuestID
WHERE Reservations.ReservName = 'Special Offer';

COMMIT;


INSERT INTO Guests_Archive (GuestID, Name, Money, StayEnded)
SELECT GuestID, Name, Money, DepartureDate
FROM Guests
WHERE DepartureDate IS NOT NULL
AND GuestID NOT IN (SELECT GuestID FROM Guests_Archive);

--7 ��������--
SELECT GuestID, Name, Money
FROM Guests
WHERE Money >= (SELECT AVG(Money) FROM Guests) 
AND GuestID IN (SELECT GuestID FROM Reservations);

--8 ��������--

WITH ReservationCount AS (
    SELECT GuestID, COUNT(ReservationID) AS NumberOfReservations
    FROM Reservations
    GROUP BY GuestID
)
SELECT * FROM ReservationCount;

WITH ReservationCount AS (
    SELECT GuestID, COUNT(ReservationID) AS NumberOfReservations
    FROM Reservations
    GROUP BY GuestID
)
SELECT COUNT(*) AS GuestsWithMultipleReservations
FROM ReservationCount
WHERE NumberOfReservations > 1;
