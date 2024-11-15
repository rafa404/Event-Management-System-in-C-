-- Create a new table for booked events
CREATE TABLE BookedEvents (
    BookingID INT PRIMARY KEY IDENTITY(1,1), -- Auto-incrementing BookingID as primary key
    BookedEventName VARCHAR(100) NOT NULL, -- Name of the booked event
    BookedEventDate DATE NOT NULL, -- Date of the booked event
    UserID INT NOT NULL, -- Foreign key referencing UserID in Registration table
    Email VARCHAR(255) NOT NULL, -- Customer's email address from Registration table
    CONSTRAINT FK_Registration_UserID FOREIGN KEY (UserID) REFERENCES Registration(UserID)
);
