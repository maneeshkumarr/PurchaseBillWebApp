
💡 Project Overview
The main goal of this web app is to allow users to:

Add items with their name, rate, and quantity

Display a list of all added items

Show total quantity, total amount, and generate a tax-inclusive invoice

Clear items or print a bill with a single click

⚙ Technologies Used
Frontend: Razor Pages, Bootstrap

Backend: ASP.NET Core (.NET 9), C#

Database: SQLite

ORM: Entity Framework Core

Tools: Visual Studio, EF Migrations

🧩 Project Structure
Models

PurchaseItem: Represents the item entity with properties like Id, ItemName, Rate, and Quantity.

PurchaseContext: Inherits from DbContext, manages the PurchaseItems table.

PurchaseContextFactory: Helps EF Core tools create the context during migration.

Migrations

Handles schema generation for the PurchaseItems table.

Creates and updates the database using dotnet ef migrations add and update.

Pages

Index.cshtml: Form for adding items and displaying saved items.

Invoice.cshtml: Displays subtotal, GST (18%), and grand total. Includes print functionality.

Code Behind

IndexModel.cs: Handles adding and clearing items using OnPost and OnPostClear.

InvoiceModel.cs: Fetches items, calculates subtotal, tax, and total.

📦 Database Table
PurchaseItems table created using EF Core Migration:

Column	Type	Description
Id	INTEGER	Auto-incremented PK
ItemName	TEXT	Name of the item
Rate	TEXT	Item price/unit
Quantity	INTEGER	Quantity purchased

🖥 Demo Flow
User lands on the Index page.

Fills the form and submits item data.

Items get stored in the SQLite database.

User can see:

All saved items in a table

Total quantity and total amount

With a click:

Clear all items

Navigate to Invoice page

On Invoice page:

Subtotal, GST (18%), and Grand Total are auto-calculated.

Button to print the invoice

💰 Business Logic Example
Subtotal = Rate × Quantity (for all items)

GST = Subtotal × 0.18 (18%)

Grand Total = Subtotal + GST

🧪 Why EF Core & Razor Pages?
EF Core simplifies database interaction without SQL

Razor Pages are page-centric and clean for small CRUD apps

Fast development and easy integration with Bootstrap

📈 Future Improvements
Add user authentication

Export invoice as PDF

Update/delete items feature

Add categories or search filters

Use a relational database like SQL Server in production

🙏 Conclusion
To summarize, this Purchase Bill Web App is a great example of how .NET Razor Pages and Entity Framework can be combined to build a functional and simple web app for real-world needs like billing and inventory.

Thank you! I'm open to any questions you may have.
