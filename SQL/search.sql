USE HotelManagment;
GO

SELECT * 
FROM Guests
WHERE Name LIKE '%Îëåíà%';

SELECT * 
FROM Reservations
WHERE ReservationID IN (SELECT ReservationID FROM Guests WHERE GuestID = 1);

SELECT * 
FROM Rooms
WHERE Type = 1;

SELECT r.*
FROM Rooms r
JOIN Reservations res ON r.Reservation = res.ReservationID
WHERE res.Come >= '2024-11-01' AND res.Leave <= '2024-11-05';

SELECT * 
FROM Guests
WHERE Date > '2024-11-01';

SELECT * 
FROM Guests
WHERE Town = 'Êè¿â';

SELECT * 
FROM Rooms
WHERE TV = 1 AND Balcony = 1;
