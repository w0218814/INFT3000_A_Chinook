
---

# PROG2500 - Assignment 3 - Chinook with LINQ 

**Note:** For this assignment, I used the same repository that was cloned for Assignment 2. Therefore, the namespace remains `PROG2500_A2_Chinook`.

## Modifications to Existing Pages:

### Artist Page:
- Added a search bar.
- Enabled functionality to filter and display artists by a search term present in the artist's name.

### Album Page:
- Added a search bar.
- Enabled functionality to filter and display albums by a search term present in the album title.

### Tracks Page:
- Added a search bar.
- Enabled functionality to filter and display tracks by a keyword present in the track title.

## New Pages Created:

### Music Catalog:
- Created a page that is searchable by artist name.
- Displayed grouped data by the first letter of the artist's name.
- Showed artists, their albums, and tracks in a nested, expandable list view structure.
- Each artist's section is expandable to show their albums, and each album further expands to show its tracks.

### Customer Orders:
- Created an initial view, with an option to display all customers or perform a search.
- Added search functionality to filter customers by last name.
- Displayed customer details in "last name, first name" order, including city, state (with a handling for missing state data), country, and email address.
- Included a collapsible section for each customer to view all their invoices, showing the invoice date, total, and the count of tracks purchased. This utilizes navigation properties to access related invoices without retrieving invoice line data directly.

Both of these new pages incorporated the use of LINQ for data handling and filtering as per the requirements.

The code for existing pages was updated to include the search functionality, and the new pages were designed with the required features. The user interface was made intuitive, including elements like tool tips and button bars to assist with navigation. Additionally, the search and expand/collapse functionalities were thoroughly tested to ensure seamless operation with the dataset.

---