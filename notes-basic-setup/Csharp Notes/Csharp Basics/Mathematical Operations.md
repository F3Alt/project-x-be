## C# Mathematical Operations

### Introduction

This guide covers performing basic mathematical operations in C#. It starts with addition and expands to other operations, highlighting how the C# compiler parses and interprets code.

### Adding Two Numeric Values

To add two numbers together, use the addition operator (`+`). The same symbol used for string concatenation is also used for addition, demonstrating operator overloading in C#.

`int firstNumber = 12; int secondNumber = 7; Console.WriteLine(firstNumber + secondNumber);`

**Output:**

`19`

### Mixing Data Types

When using the `+` symbol with both string and int values, the compiler performs implicit type conversion.

#### Example:

`string firstName = "Bob"; int widgetsSold = 7; Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");`

**Output:**

`Bob sold 7 widgets.`

### Advanced Concatenation and Addition

Combining addition and concatenation can lead to unexpected results.

#### Example:

`string firstName = "Bob"; int widgetsSold = 7; Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");`

**Output:**


`Bob sold 77 widgets.`

### Clarifying Intentions with Parentheses

Use parentheses to specify the order of operations explicitly.

#### Example:


`string firstName = "Bob"; int widgetsSold = 7; Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");`

**Output:**


`Bob sold 14 widgets.`

### Recap

- The `+` operator is used for both addition and string concatenation.
- The compiler implicitly converts data types to aid in concatenation.
- Parentheses help specify the order of operations clearly.

### Perform Basic Math Operations


`int sum = 7 + 5; int difference = 7 - 5; int product = 7 * 5; int quotient = 7 / 5;  Console.WriteLine("Sum: " + sum); Console.WriteLine("Difference: " + difference); Console.WriteLine("Product: " + product); Console.WriteLine("Quotient: " + quotient);`

**Output:**

`Sum: 12 Difference: 2 Product: 35 Quotient: 1`

### Division with Decimal Data Types

To retain values after the decimal point, use the `decimal` data type.

#### Example:


`decimal decimalQuotient = 7.0m / 5; Console.WriteLine($"Decimal quotient: {decimalQuotient}");`

**Output:**


`Decimal quotient: 1.4`

#### Additional Examples:


`decimal decimalQuotient = 7 / 5.0m; decimal decimalQuotient = 7.0m / 5.0m;`

### Casting for Division

When dividing two `int` variables, cast them to `decimal` to avoid truncation.

#### Example:

`int first = 7; int second = 5; decimal quotient = (decimal)first / (decimal)second; Console.WriteLine(quotient);`

**Output:**


`1.4`

### Modulus Operator

The modulus operator `%` returns the remainder of integer division.

#### Example:


`Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}"); Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");`

**Output:**


`Modulus of 200 / 5 : 0 Modulus of 7 / 5 : 2`

### Order of Operations

C# follows the order of operations similar to PEMDAS, except there's no exponent operator.

#### Example:


`int value1 = 3 + 4 * 5; int value2 = (3 + 4) * 5; Console.WriteLine(value1); Console.WriteLine(value2);`

**Output:**


`23 35`

### Recap

- Use operators `+`, `-`, `*`, and `/` for basic math operations.
- Division of `int` values truncates the result. Use `decimal` for precise division.
- Perform a cast to treat a value as a different data type.
- Use `%` to get the remainder of a division.
- Follow the PEMDAS order of operations.

### Clarifying Postfix Increment with Order of Output

Let's re-examine the example using postfix increment and observe the difference when printing `y` before `x`:


`int x = 5; int y = x++; Console.WriteLine($"y: {y}, x: {x}");`

**Output:**

`y: 5, x: 6`

**Explanation:**

- The original value of `x` (which is 5) is assigned to `y`.
- After the assignment, `x` is incremented to 6.
- When printed, `y` shows 5 and `x` shows 6.

Printing `y` before `x` clearly demonstrates that `y` holds the original value of `x` before the increment occurs.

### When Does the Compiler Evaluate and Print Values?

#### Evaluation vs. Printing

1. **Evaluation**:
    
    - The compiler evaluates the expressions and determines the values of all variables before any output operations are executed.
    - In the example, the compiler evaluates `y = x++`, assigns the current value of `x` to `y` (which is 5), and then increments `x` to 6.
2. **Printing**:
    
    - The `Console.WriteLine` method is a runtime operation that takes the evaluated values and sends them to the standard output.
    - The actual printing to the console happens during the runtime execution of `Console.WriteLine`.

#### Compiler's Role

- **Compile-Time**: The compiler translates the source code into intermediate language (IL) code and embeds instructions for evaluating expressions and output operations.
- **Run-Time**: The .NET runtime executes these instructions, evaluates expressions, and performs the output operations.

So, the compiler knows the values of the variables at the point of evaluation (compile-time). However, the actual printing to the console happens at runtime, and the values are sent to the output stream in the order specified in the `Console.WriteLine` method call.

### Order of Evaluation in Console.WriteLine

The `Console.WriteLine` method evaluates all the arguments before any of them are printed. This ensures that all expressions within the method call are fully resolved before any output is generated. Here's an illustrative example:

```
int x = 5; int y = x++; Console.WriteLine($"y: {y}, x: {x}");
```

**Step-by-Step Evaluation**:

1. Evaluate `y = x++`:
    
    - `y` is assigned the current value of `x` (5).
    - `x` is then incremented to 6.
2. Prepare the string for `Console.WriteLine`:
    
    - Substitute `y` with its value (5).
    - Substitute `x` with its value (6).
    - Form the final string: `"y: 5, x: 6"`.
3. Print the string:
    
    - The `Console.WriteLine` method sends the string `"y: 5, x: 6"` to the standard output.

Thus, the order of evaluation and printing ensures that the values are fully determined before any output is made.

# Convert Fahrenheit to Celsius
```
int fahrenheit = 94;

// The division 5 / 9 is performed as a decimal division to ensure the correct result.
decimal celsius = (fahrenheit - 32) * (5m / 9m);

// Math.Round is used to round the result to 2 decimal places for better readability.
celsius = Math.Round(celsius, 2);

Console.WriteLine($"The temperature is {celsius} Celsius.");

```
**Important Notes:**

1. **Decimal Division:**
    
    - When performing the division `(5 / 9)`, ensure at least one of the operands is a decimal (or floating-point) number to avoid integer division.
    - In this example, `5m` and `9m` are used to indicate that `5` and `9` are decimals, resulting in a correct decimal division.
2. **Rounding:**
    
    - The `Math.Round` method is used to round the result to a specified number of decimal places. This is useful for making the output more readable.
    - Here, the result is rounded to 2 decimal places with `Math.Round(celsius, 2)`.
3. **Temperature Conversion Formula:**
    
    - The formula `(fahrenheit - 32) * (5m / 9m)` is used to convert Fahrenheit to Celsius.
    - The subtraction `(fahrenheit - 32)` adjusts the Fahrenheit value to start the conversion process.
    - The multiplication by `(5m / 9m)` scales the adjusted value to the Celsius equivalent.

**Output:**

`The temperature is 34.44 Celsius.`

This ensures the temperature conversion from Fahrenheit to Celsius is accurate and the result is formatted to a readable two decimal places.