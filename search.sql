USE HotelManagment;
GO

-- Пошук гостей за іменем
SELECT * 
FROM Guests
WHERE Name LIKE '%Олена%';

-- Пошук всіх бронювань для певного гостьа за ID
SELECT * 
FROM Reservations
WHERE ReservationID IN (SELECT ReservationID FROM Guests WHERE GuestID = 1);

-- Пошук всіх номерів за певним типом номера
SELECT * 
FROM Rooms
WHERE Type = 1;

-- Пошук всіх номерів, що зарезервовані на певну дату
SELECT r.*
FROM Rooms r
JOIN Reservations res ON r.Reservation = res.ReservationID
WHERE res.Come >= '2024-11-01' AND res.Leave <= '2024-11-05';

-- Пошук гостей, які приїхали до готелю після певної дати
SELECT * 
FROM Guests
WHERE Date > '2024-11-01';

-- Пошук гостей, що проживають в певному місті
SELECT * 
FROM Guests
WHERE Town = 'Київ';

-- Пошук номерів з певними зручностями (наприклад, наявність телевізора і балкона)
SELECT * 
FROM Rooms
WHERE TV = 1 AND Balcony = 1;
