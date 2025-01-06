### String Concatenation

String concatenation involves combining multiple strings or variables into a single string using the `+` operator.
#### Example:

```
using System;  class Program {     static void Main()     {         string firstName = "Bob";         int number = 3;         float temp = 34.4f;          // Using string concatenation         string message = "Hello, " + firstName + "! You have " + number + " messages in your inbox. The temperature is " + temp + " Celsius.";         Console.WriteLine(message);     } }
```

#### Output:

`Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 Celsius.`

#### Advantages of String Concatenation:

- Simple and straightforward for combining a few strings.
- No additional syntax to learn beyond the `+` operator.

#### Disadvantages of String Concatenation:

- Can become unwieldy and less readable with many variables or complex strings.
- Less efficient because it creates multiple intermediate strings during concatenation, especially in loops.

### String Interpolation

String interpolation allows you to embed expressions directly within a string literal, making the code more readable and maintainable.

#### Example:

```
using System;  class Program {     static void Main()     {         string firstName = "Bob";         int number = 3;         float temp = 34.4f;          // Using string interpolation         string message = $"Hello, {firstName}! You have {number} messages in your inbox. The temperature is {temp} Celsius.";         Console.WriteLine(message);     } }
```

#### Output:

`Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 Celsius.`

#### Advantages of String Interpolation:

- More readable and maintainable, especially with multiple variables.
- Directly embeds variables and expressions within the string.
- Avoids the creation of multiple intermediate strings, potentially improving performance.

#### Disadvantages of String Interpolation:

- Requires C# 6.0 or later.
- Slightly more complex syntax compared to simple concatenation.

### Summary

- **String Concatenation**:
    
    - Uses the `+` operator to combine strings.
    - Simple but can become cumbersome with many variables.
    - Example: `"Hello, " + firstName + "! You have " + number + " messages in your inbox."`
- **String Interpolation**:
    
    - Embeds expressions within a string literal using `$` and `{}`.
    - More readable and easier to maintain, especially for complex strings.
    - Example: `$"Hello, {firstName}! You have {number} messages in your inbox."`


### Escape Sequences in C#

#### 1. New Line (`\n`)

The `\n` escape sequence represents a new line character, which moves the cursor to the beginning of the next line. It is used to insert line breaks within a string.

#### Example:

```
using System;  class Program {     static void Main()     {         string message = "Hello, world!\nWelcome to C# programming.";         Console.WriteLine(message);     } }
```

#### Output:

`Hello, world! Welcome to C# programming.`

#### 2. Tab (`\t`)

The `\t` escape sequence represents a horizontal tab, which adds a tab space in the string. It is used to align text or create indents.

#### Example:

```
using System;  class Program {     static void Main()     {         string message = "Item\tPrice\nApple\t$1.00\nBanana\t$0.50";         Console.WriteLine(message);     } }
```

#### Output:

`Item    Price Apple   $1.00 Banana  $0.50`

#### 3. Backslash (`\\`)

The `\\` escape sequence represents a single backslash character. Since the backslash is used as an escape character, you need to use `\\` to include an actual backslash in the string.

#### Example:

```
using System;  class Program {     static void Main()     {         string filePath = "C:\\Users\\Alice\\Documents\\file.txt";         Console.WriteLine(filePath);     } }
```

#### Output:

```
C:\Users\Alice\Documents\file.txt
```

### Summary of Escape Sequences

- **New Line (`\n`)**: Moves the cursor to the beginning of the next line.
    
    - Example: `"Hello\nWorld"`
    - Output:
        
        `Hello World`
        
- **Tab (`\t`)**: Inserts a horizontal tab space.
    
    - Example: `"Name\tAge"`
    - 
        `Name    Age`
        
- **Backslash (`\\`)**: Inserts a single backslash character.
    
    - Example: `"C:\\Path\\To\\File"`
    - Output: `C:\Path\To\File`

### Example Combining Escape Sequences

```
using System;  class Program {     static void Main()     {         string message = "Path:\tC:\\Users\\Alice\\Documents\nFile:\tfile.txt";         Console.WriteLine(message);     } }
```

#### Output:

`Path:   C:\Users\Alice\Documents File:   file.txt`

### Usage in Different Contexts

Escape sequences are particularly useful for formatting output, aligning text, specifying file paths, and including special characters in strings.


### Verbatim String Literals

Verbatim string literals are created using the `@` symbol before the string. They allow you to include new lines and backslashes without needing escape sequences.

### String Interpolation

String interpolation is done using the `$` symbol before the string. It allows you to embed expressions inside string literals, which are evaluated and included in the final string.

### Combining Verbatim Literals and String Interpolation

To combine both features, you use both the `@` and `$` symbols together, like `@$"..."`.

### Example

#### Using Verbatim Literals

Using verbatim literals, you can include new lines and backslashes directly in your string without escape sequences.


```
string filePath = @"C:\Users\Alice\Documents\file.txt"; Console.WriteLine(filePath);
```

#### Using String Interpolation

String interpolation allows embedding expressions within a string.

csharp

Copy code

```
string firstName = "Alice"; int messages = 5; Console.WriteLine($"Hello, {firstName}! You have {messages} new messages.");
```

#### Combining Both

To use both features, use `@$` or `$@` before the string. This is useful for multi-line strings or file paths that include variable values.

```
using System;  class Program {     static void Main()     {         string firstName = "Alice";         int messages = 5;         string filePath = "C:\\Users\\Alice\\Documents";          string message = @$"Hello, {firstName}! You have {messages} new messages. Your documents are located at: {filePath}\file.txt";          Console.WriteLine(message);     } }
```

### Output

`Hello, Alice! You have 5 new messages. Your documents are located at: C:\Users\Alice\Documents\file.txt`

### Explanation

1. **`@$` or `$@`**: Using both symbols together allows combining verbatim literals and string interpolation.
2. **Multi-line Strings**: You can easily create multi-line strings without needing `\n` for new lines.
3. **File Paths**: Backslashes in file paths can be included directly without needing to escape them.

### Example with Detailed Steps

```
using System;  class Program {     static void Main()     {         // Declare variables         string firstName = "Alice";         int messages = 5;         string filePath = @"C:\Users\Alice\Documents";          // Combine verbatim literal and string interpolation         string message = @$"Hello, {firstName}! You have {messages} new messages. Your documents are located at: {filePath}\file.txt";          // Print the message         Console.WriteLine(message);     } }
```

### Summary

- **Verbatim Literals (`@`)**: Allows multi-line strings and includes backslashes without escaping.
- **String Interpolation (`$`)**: Embeds expressions within strings.
- **Combining (`@$` or `$@`)**: Enables using both features together for readable and maintainable strings, especially useful for multi-line messages and file paths.