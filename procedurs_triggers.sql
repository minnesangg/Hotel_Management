USE HotelManagment;
GO

--Процедури--
--Список доступних для бронювання номерів--
CREATE PROCEDURE GetAvailableRooms
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT Number AS RoomID, Type AS RoomCategory, Bed AS Beds, Storey
    FROM Rooms
    WHERE Number NOT IN (
        SELECT Reservation
        FROM Reservations
        WHERE (Come <= @EndDate AND Leave >= @StartDate)
    );
END;

EXEC GetAvailableRooms @StartDate = '2024-01-01', @EndDate = '2024-01-05';

--Тригери--
--Оновлення статусу(вільний, зайнятий) залежно від наявності бронювань
CREATE TRIGGER trg_UpdateRoomStatus
ON Reservations
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
    UPDATE Rooms
    SET Reservation = (SELECT ReservationID FROM INSERTED)  
    WHERE Number IN (SELECT Reservation FROM INSERTED);  
    UPDATE Rooms
    SET Reservation = NULL 
    WHERE Number IN (SELECT Reservation FROM DELETED);  
END;
GO
