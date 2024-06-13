```
BEGIN
	CLASS Program
		Main METHOD
			PRINT
-	"enter a number:");
    			VAR num = Convert.ToInt32(Console.ReadLine());
    			VAR sum = 0;
    			for (var i = num-1; i > 0; i--) {
      				if (num % i == 0) {
        				sum += i;
      				}
    			}
    			if (sum == num) {
      				Console.WriteLine("Perfect Number");
    			} else {
      				Console.WriteLine("Not A Perfect Number");
    			}
    			Console.WriteLine("Passed");
		END Main
	END Program
END
```
