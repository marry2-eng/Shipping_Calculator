# Shipping Calculator Requirements

## Details

Your job is to create a console-based application for getting a shipping quote for a package.

## Requirements

1. The first line of the program must be: "Welcome to Package Express. Please follow the instructions below."
2. The user must then be prompted for the package weight.
3. If the weight is greater than 50, display the error message, "Package too heavy to be shipped via Package Express. Have a good day." At this point the program should end.
4. The user must then be prompted for the package width.
5. Then the package height.
6. Then the package length.
7. If the total dimensions are greater than 50, display the error message, "Package too large to be shipped via Package Express." At this point, the program should end.
8. Next, multiply the three dimensions (height, width, and length) together, and multiply the product by the weight. Finally, divide the outcome by 100.
9. The result of that calculation is the quote.
10. Display the quote to the user as a dollar amount.

### Example

```
Welcome to Package Express. Please follow the instructions below.

Please enter the package weight:
40

Please enter the package width:
10

Please enter the package height:
12

Please enter the package length:
11

Your estimated total for shipping this package is: $528.00

Thank you!
```

11. Add comments to each line or block of your code to explain exactly what it does, so that another developer could read and understand your code.