CREATE TABLE BookedEvents (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    BookedEventName VARCHAR(100) NOT NULL,
    BookedEventDate DATE NOT NULL,
    Name VARCHAR(50) NOT NULL,
);
