# Meeting Events
> An event manager to setup meetings and communicate their whereabouts

# Scope
This program uses a variety of different technologies to create a functional social media platform that allows users and clients to create events, such as parties or meetings for get-togethers, and communicate statuses, date and time, and locations for those events similar to Meetup.

# Structure
The overall program is divided up into smaller, loosly coupled projects for Domain Driven Design patterns based on the S.O.L.I.D pricniples.

The projects are contained in a source folder `src/` under a directory named `MeetingEvents`, where a solution file is found for use with Visual Studio. 

The business logic is contained in the `Applications` directory, the Database and ORM tools are in the `Persistence`, The domain eccentric universe, that is not dependent on any other projects, is in the `Domain`. Finally, the web API is locatied in the `Api`, which contains our controller (RESTful) endpoints.

# Technologies
The application is built with the following:
- ASP.Net Core 2.2 for the web api
- SingleR for real time updates
- React 16 for the client UI/UX
- Entity Framework Core as the ORM and SQL Server for the database
- Azure for cloud hosting