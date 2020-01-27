# Meeting Finder

> An event manager to setup meetings and communicate their whereabouts

## Scope

This program uses a variety of different technologies to create a functional social media platform that allows users and clients to create and find meetings or activities such as: parties, conferences, or get-togethers, and communicate update status, their date and time, and locations.

This application centers around the use of separating logic layers in different class libraries. It is to provide thin controller methods and modularity for ease of changes.

## Structure

The overall program is divided up into smaller, loosely coupled projects for Domain Driven Design patterns based on Uncle Bob's clean architecture.

The projects are contained in a source folder `src/` under a directory named `MeetingFinder` (naming this has been an ongoing change), containing a solution file for use with Visual Studio.

The business logic is contained in the `Applications` directory, the Database and ORM tools are in the `Persistence`, The domain eccentric universe, that is not dependent on any other projects, is in the `Domain`. Finally, the web API is located in the `Api`, which contains our controller (RESTful) endpoints.

## Technologies

The application is built with the following:

- ASP.Net Core 3.1 for the web api
- SingleR
- MediatR for clean architecture
- React 16 for the client UI/UX
- Entity Framework Core as the ORM and soon PostgreSQL for the database
- Azure for cloud hosting
