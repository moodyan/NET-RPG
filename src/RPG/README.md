# RPG

#### _App created for Epicodus in-class project, ASP.NET - Week Two. Practice using testing and user authentication. August 9th, 2017_

#### By **Alyssa Moody and Marilyn Carlin**

## Description

_A role playing game in a web application that allows users to choose a role and navigate from place to place collecting items and defeating foes._

## Program Specifications

| Description  | Input Example | Output Example |
| ------------- | ------------- | ------------- |
| The program allows users to view a landing page.  | Home  | "Welcome"  |
| The program allows users to create an account.  | New Account  | "Enter your information"  |
| The program allows users to edit their account info.  | /Account/Edit  | Form for editing  |
| The program allows users to delete their account.  | /Account/Delete  | "Are you sure?"  |
| The program allows users to add an image for their avatar.  | Upload Form  | Account Detail Page  |
| The program allows users to edit their avatar's image (and maybe delete it as well).  | Upload Form  | Replaces old avatar  |
| The program allows users to view all saved items.  | View all Items  | Item Page  |
| The program allows users to view details page for an item with options to edit and delete saved items.  | View details  | Item Detail Page  |
| The program allows users to view all locations.  | "Enter Game Play"  | Gameplay (Location) Page  |
| The program allows users to visit a location and see .  | "Visit the Library"  | Location Detail Page  |
| The program allows admins to create, edit, delete locations.  | --  | Admin Portal  |
| The program allows admins to create, edit, delete items.  | --  | Admin Portal  |
| The program allows admins to create, edit, delete foes.  | --  | Admin Portal  |
| The program allows users to "interact" with foes.  | --  | Location Detail Page  |

**STRETCH GOALS**
1. Add SASS
2. Users will have a default avatar that can't be deleted.
3. Users can view items by category.
4. Extended game play.

## Setup/Installation Requirements

**Requirements**

If you do not have Visual Studio 2017, download [HERE](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15).

If you do not have SSMS, download [HERE](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).

**Cloning From GitHub:** Download or clone project repository onto desktop from GitHub.

Open the project in Visual Studio.

**Migrations**
1. In Solution Explorer, right-click the project and choose 'Open in File Explorer' from the context menu.
2. Enter "cmd" in the address bar and press Enter.
3. Enter the following command in the command window:
  - dotnet ef database update
4. Open scripts.sql in SSMS and execute (this will add sample data).
5. Back in VS, click IIS Express at the top of the window. Project should open in a new window in your default browser.

## Known Bugs

_No known bugs._

## Support and contact details

_If you run into any issues or have questions, ideas or concerns, please contact Alyssa Moody at alyssanicholemoody@gmail.com or Marilyn Carlin at marilyn.s.carlin@gmail.com_

## Technologies Used

**Languages:** HTML, CSS, C#, ASP.NET

**IDE:** Visual Studio 2017

**Database Management:** MySQL (SSMS)

### License

*MIT license Agreement*

Copyright (c) 2017 **_Alyssa Moody and Marilyn Carlin_*
