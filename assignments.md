# Web API recruitment assessment #
## Introduction ##
This file contains assignments for the accompanying web application code base.

While performing these assignments you are allowed to use any online resource and/or ask questions to the recruitment team. These assignments are intended to evaluate the candidate's approach in developing applications and not to test for ready knowledge.

The assessment contains 4 assignments and 2 bonus assignments. This does not at all mean that the assignments must be completed for a positive assessment. The recruitment team prefers clean code over finished assignments.

The recruitment team encourages candidates to observe clean code guidelines and S.O.L.I.D. principles when making the assignments.

## Context: ##
The code accompanying this assignment is a simple web API for storing and retrieving locations that we will be extending. In its initial implementation the web API can store only a single location. A location is a set of coordinates defined by a latitude in degrees and a longitude in degrees. The API contains two endpoints. One endpoint retrieves the currently stored location and one endpoint can change the currently stored location.

The program consists of the following classes:
 - `Program` - Provides the entrypoint for the program.
 - `LocationsController` - Contains the controller logic for the web API and defines the two endpoints.
 - `InMemoryLocationRepository` - An in-memory storage component for the web API.
 - `Location` - Defines the storage model of a location and defines the JSON serialization.

## Assignments: ##
### 1. Change Get API to return a list of locations ###
The HTTP GET api on the locations controller currently returns the last posted location (or a default location if none have been posted).

Please change the implementation of the locations controller and the locations repository so that it returns a list of all posted locations. If no locations have been posted the list should be empty.

### 2. Resolve ambiguity between latitude and longitude. ###
The constructor of the `Location` class take two parameters. Latitude and longitude, in that order. Both these parameters are of type `double`. This causes the constructor to have the following signature:

> `Location(double, double)`

This is ambiguous and is often the cause of bugs because the compiler cannot check the proper values are passed into the proper parameter.

Please change the Location class so that this ambiguity is avoided, and correct invocation of the constructor can be verified by the compiler.

### 3. Break the dependency between the classes `LocationsController` and `LocationRepository`
The class `LocationsController` is directly dependent on the implementation of the class `LocationRepository`. The S.O.L.I.D. principles teach us this is not a good maintainable design. Improve upon the design by breaking this dependency.

### 4. Add API to get the distance between two locations in the list. ###
Add a new API to the locations controller that returns the disance in metres between the two locations in the list.

For calculating the difference in metres between two geodetic angles use a simplified formula:
> delta metres = delta degrees * pi / 180.0 * 6378137

## Bonus assignment 1: ##
Add unit testing using a unit testing framework of your choice

## Bonus assignment 2: ##
Change Locations repository to work with a database and/or ORM of your choice
