USE [Event Management System]; -- Use your database name

-- Create a new table for booked events
CREATE TABLE BookedEvents (
    BookingID INT PRIMARY KEY IDENTITY(1,1), -- Auto-incrementing BookingID as primary key
    BookedEventName VARCHAR(100) NOT NULL, -- Name of the booked event
    BookedEventDate DATE NOT NULL, -- Date of the booked event
    CustomerName VARCHAR(100) NOT NULL, -- Customer's name
    CustomerEmail VARCHAR(255) NOT NULL -- Customer's email address
);