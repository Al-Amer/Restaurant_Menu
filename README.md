# Restaurant_Menu
Restaurant Menu &amp; Order Management System.




This  project you’ll cook up a tasty Restaurant Menu & Order Management System. Guests can browse a menu, place sample orders, and view summaries of what’s cooking, all via Minimal API endpoints with Entity Framework Core and a clean Scalar UI for testing. Along the way you’ll explore data modeling, migrations, seeding, and robust validation, giving you a rock-solid foundation for real-world web services.

⌛ Duration: 5 days (Full Time) / 10 Days (Part Time)

📈 Presentation: TBD by Instructor | Mandatory

📝 Project Requirements

ID	Functional Requirement	Description
FR001	Project Bootstrap	Initialise an ASP.NET Core Web API with Minimal APIs (dotnet new webapi )
FR002	EF Core Setup	Add EF Core and a local provider (SQLite). Register DbContext in DI.
FR003	Database Design	Create models: MenuItem, Order, OrderItem. Relationships: Order (1) — (many) OrderItem — (1) MenuItem.
FR004	Migrations & Seeding	Create initial migration; apply with dotnet ef database update. Seed 8–12 sample MenuItem rows on startup if DB empty.
FR005	Menu Endpoints (CRUD)	Minimal API routes: GET /menu, GET /menu/{id}, POST /menu, PUT /menu/{id}, DELETE /menu/{id}. Return proper status codes.
FR006	Search & Filter	Extend GET /menu with optional query params: q (name contains), category, minPrice, maxPrice.
FR007	Order Creation	POST /orders accepts a payload with line items { menuItemId, quantity }. Validates items exist; computes TotalAmount server-side; saves Order + OrderItems.
FR008	Order Retrieval	GET /orders lists orders with summary; GET /orders/{id} returns full details (items, quantities, extended line totals).
FR009	Daily Summary Report	GET /reports/daily?date=YYYY-MM-DD returns: order count, total revenue, top 3 items (by quantity).
FR010	DTOs & Validation	Define MenuItemDto, CreateOrderDto, OrderItemDto. Validate with FluentValidation or manual checks; return 400 with errors.
FR011	Error Handling	Add global exception handler (app.UseExceptionHandler) or middleware; return problem details for DB errors, not stack traces.
FR012	ScalarUI/OpenAPI	Enable OpenAPI annotate endpoints and schemas so the API is fully testable from Scalar UI.
FR013	Project Structure	Follow the directory structure we’ve practised so far.
FR014	Endpoint Grouping	Group routes with MapGroup: /menu, /orders, /reports. Apply minimal route constra
🤓 Tips for Effective Planning

Model first: Get your EF Core models and relationships working before getting into service logic.
Iterate: First get menu working → then orders → then reports.
Keep it simple: Don’t overcomplicate; 3 entities are enough for a strong demo.
When your first order prints out on the dashboard, you’ll see how smoothly ASP.NET + EF can turn database tables into a polished, interactive web app.


