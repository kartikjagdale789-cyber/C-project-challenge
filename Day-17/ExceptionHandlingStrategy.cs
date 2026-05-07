using System;

class ExceptionHandlingStrategy {
    static void Main() {
        try {
            int x = 10, y = 0;
            int result = x / y;
        }
        catch (DivideByZeroException ex) {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex) {
            Console.WriteLine("General Error: " + ex.Message);
        }
        finally {
            Console.WriteLine("Execution Completed");
        }
    }
}