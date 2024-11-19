USE HotelManagment;
GO

-- ќсновной запрос с агрегированными данными по гост€м и номерам
SELECT 
    SUM(g.Money) AS TotalRevenue, 
    AVG(g.Money) AS AverageSpend, 
    COUNT(CASE WHEN g.Date = '2024-11-01' THEN 1 END) AS GuestCount, 
    COUNT(CASE WHEN r.Balcony = 1 THEN 1 END) AS RoomsWithBalcony,
    MAX(g.Money) AS MaxMoney,
    MIN(g.Money) AS MinMoney,
    AVG(g.Money) AS AvgMoney,
    COUNT(CASE WHEN r.Reservation IS NULL THEN 1 END) AS AvailableRooms,
    COUNT(CASE WHEN r.Reservation IS NOT NULL THEN 1 END) AS ReservedRooms
FROM Guests g
JOIN Rooms r ON r.Reservation = g.Receipt
WHERE g.Date BETWEEN '2024-11-01' AND '2024-11-05';

-- «апрос дл€ дохода по каждому типу номера
SELECT 
    r.Type, 
    SUM(g.Money) AS TypeRevenue
FROM Rooms r
JOIN Guests g ON r.Reservation = g.Receipt
WHERE g.Date BETWEEN '2024-11-01' AND '2024-11-05'
GROUP BY r.Type;

