USE [Event Management System]; -- Select the database

-- Create a new table named Events
CREATE TABLE Events (
    EventID INT PRIMARY KEY IDENTITY(1,1), -- Auto-incrementing EventID as primary key
    EventType VARCHAR(50) NOT NULL, -- Event type field
    EventName VARCHAR(100) NOT NULL, -- Event name field
    EventDate DATE NOT NULL, -- Event date field
    Venue VARCHAR(100) NOT NULL, -- Venue field
    Address VARCHAR(255) NOT NULL -- Address field
);