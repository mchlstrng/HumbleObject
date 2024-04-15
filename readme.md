Creating a Humble Object that works with a GUI in an ASP.NET Core application involves separating the UI logic from the business logic. Here’s a simple example where we have a CalculatorService that performs a calculation, which is easy to test, and a CalculatorController that acts as the Humble Object interfacing with the GUI.

In this example:

- CalculatorService contains the core business logic for adding two numbers. This service can be easily unit tested.

- CalculatorController is the Humble Object. It uses CalculatorService to perform the calculation and then passes the result to the view using ViewData. The controller itself has minimal logic and serves mainly to interact with the user interface.

- The view (AddNumbers.cshtml) would be simple and just display the result:

This pattern ensures that the CalculatorService can be tested independently of the ASP.NET Core framework, while the CalculatorController remains a thin layer that doesn’t require extensive testing. The separation of concerns provided by the Humble Object pattern makes the application more maintainable and the code more testable