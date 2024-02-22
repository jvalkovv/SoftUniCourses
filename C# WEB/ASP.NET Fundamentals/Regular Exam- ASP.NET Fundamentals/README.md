# SeminarHub ASP.NET Core Project

## Introduction
This project is a simple ASP.NET Core application using the Model-View-Controllers (MVC) pattern. 
It is designed for managing seminar events, allowing users to create, edit, and delete seminars. 
Additionally, users can join other seminars, and the platform provides a user-friendly interface to navigate through seminar details.

## Getting Started
To access the SeminarHub Platform, click [here](https://gndstore.hopto.org:4433).

## Functionality

### Users
- Guests can Register, Login, and view the Index Page.
- Registered users can add seminars, edit and delete only the seminars they have added.
- Users can subscribe to seminars added by other users and view details of all seminars.
- All users can see a list of added seminars by all users on the Home Page (/Seminar/All).
- Creators of seminars can see [Edit] and [Delete] buttons for their seminars.
- Users who did not create the seminar can join the seminar.

### Seminars
- Seminars can be added by registered users.
- All created seminars are displayed on the Home Page (/Seminar/All).
- Seminars are visualized on the Home Page (/Seminar/All) with some of their information.
- Each seminar has [Details], [Edit], and [Subscribe] buttons.
  - [Details] button displays a new page with all information for the selected seminar.
  - [Edit] button allows users (creators) to modify seminar details.
  - [Subscribe] button adds the seminar to the user's collection, unless already added.
- Users have a My Seminars page where only the seminars in their collection are visualized.
- The [Unsubscribe] button removes a seminar from the user's collection.

## Usage
1. Register or log in to the SeminarHub Platform.
2. Explore seminars on the Home Page (/Seminar/All).
3. Add, edit, or delete seminars you created.
4. Subscribe to seminars added by others.
5. View and manage your seminars on the My Seminars page.

## Contributing
Feel free to contribute by forking the repository and submitting pull requests.

## License
This project is licensed under the [MIT License](LICENSE).
