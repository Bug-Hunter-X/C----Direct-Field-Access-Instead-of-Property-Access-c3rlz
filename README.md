# C# - Direct Field Access Instead of Property Access

This repository demonstrates a common coding error in C#: directly accessing private fields instead of using their associated properties.  Direct field access can bypass any validation, logging, or other logic included in the property's accessors, potentially leading to unexpected behavior, bugs, and making the code harder to maintain.

**The Problem:**

The `bug.cs` file showcases a class with a private field (`_myField`) and a corresponding property (`MyProperty`).  While the field is directly modified in `MyMethod`, the recommended practice is to always utilize the property to maintain data integrity and leverage any logic within the getter and setter methods.

**The Solution:**

The `bugSolution.cs` file demonstrates the correct approach. The private field is always accessed through the `MyProperty` ensuring proper use of the accessor methods.

**Key Learning:**

- Always use properties to access and modify class fields in C#. 
- Direct field access can introduce hard-to-find bugs and break encapsulation principles.
- Properties provide a layer of abstraction that aids maintainability and extensibility.